// ***********************************************************************
// Assembly         : Tib.Api
// Author           : cboivin
// Created          : 05-15-2019
//
// Last Modified By : cboivin
// Last Modified On : 05-15-2019
// Last Modified By : hiteshpatel
// Last Modified On : 04-12-2021
// ***********************************************************************
// <copyright file="ApiClient.cs" company="Tib.finance">
//     Copyright ©  2018
// </copyright>
// <summary></summary>
// ***********************************************************************
using Tib.Api.CryptographyService;
using Tib.Api.CryptedService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tib.Api.UiModel;
using Tib.Api.Model;
using Tib.Api.Common;

namespace Tib.Api
{
  /// <summary>
  /// Class ApiClient.
  /// </summary>
  internal class ApiClient
  {
    /// <summary>
    /// The site URL
    /// </summary>
    private string _siteUrl = "";

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient"/> class.
    /// </summary>
    /// <param name="siteUrl">The site URL.</param>
    public ApiClient(string siteUrl)
    {
      if (siteUrl.EndsWith("/"))
      {
        _siteUrl = siteUrl.Substring(0, siteUrl.Length - 1);
      }
      else
      {
        _siteUrl = siteUrl;
      }
    }

    /// <summary>
    /// Calls the specified method name.
    /// </summary>
    /// <typeparam name="Tresponse">The type of the tresponse.</typeparam>
    /// <param name="methodName">Name of the method.</param>
    /// <param name="args">The arguments.</param>
    /// <returns>Tresponse.</returns>
    public Tresponse Call<Tresponse>(string methodName, ClientCallBaseArgs args)
      where Tresponse : ClientBaseResponse, new()
    {
      Tresponse response = new Tresponse();

      HttpClient client = new HttpClient();
      client.Timeout = TimeSpan.FromMinutes(5);
      client.DefaultRequestHeaders.Add("TIB_API_Version", "0.2");

      JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto };

      //GetPublicKey
      HttpResponseMessage getPublicKeyResponse = client.PostAsync(_siteUrl + "/Data/GetPublicKey", null).Result;
      string getPublicKeyContent = getPublicKeyResponse.Content.ReadAsStringAsync().Result;
      if (getPublicKeyContent.StartsWith("{\"KeyToken\""))
      {
        PublicKeyUiModel publicKeyUiModel = new PublicKeyUiModel();
        JsonConvert.PopulateObject(getPublicKeyContent, publicKeyUiModel, settings);

        //Process Public Key
        Cryptography cryptoHelper = new Cryptography();
        RsaPublicKey serverPublicKey = cryptoHelper.AsymetricGetKey(publicKeyUiModel.PublicKeyXmlString, false).PublicKey;
        AsymetricKey clientAsymetricKey = cryptoHelper.AsymetricGetKey(1024);
        byte[] clientSymetricKeyPart = Guid.NewGuid().ToByteArray();

        List<byte> mergedKeys = new List<byte>();
        mergedKeys.AddRange(clientSymetricKeyPart);
        mergedKeys.AddRange(Encoding.UTF8.GetBytes(clientAsymetricKey.PublicKey.KeyXmlString));

        byte[] encryptedLocalPublicKeyAndClientSymetricKey = cryptoHelper.AsymetricEncryptToBytes(mergedKeys.ToArray(), serverPublicKey.KeyCspBlob);

        KeyExchangeUiModel keyExchangeArgs = new KeyExchangeUiModel()
        {
          CallNode = publicKeyUiModel.NodeAnswered,
          KeyToken = publicKeyUiModel.KeyToken,
          AsymetricClientPublicKeyAndClientSymetricXmlBase64 = Convert.ToBase64String(encryptedLocalPublicKeyAndClientSymetricKey),
        };

        string jsonKeyExchangeArgs = JsonConvert.SerializeObject(keyExchangeArgs, settings);

        //ExecuteKeyExchange
        StringContent jsonStringContentKeyExchangeArgs = new StringContent(jsonKeyExchangeArgs, UnicodeEncoding.UTF8, "application/json");
        HttpResponseMessage executeKeyExchangeResponse = client.PostAsync(_siteUrl + "/Data/ExecuteKeyExchange", jsonStringContentKeyExchangeArgs).Result;
        string executeKeyExchangeContent = executeKeyExchangeResponse.Content.ReadAsStringAsync().Result;
        KeyExchangeReturnedKey keyExchangeReturnedKey = new KeyExchangeReturnedKey();
        JsonConvert.PopulateObject(executeKeyExchangeContent, keyExchangeReturnedKey, settings);

        //Process Key Exchange
        byte[] serverSideSymetrycKeyPart = cryptoHelper.AsymetricDecryptToBytes(Convert.FromBase64String(keyExchangeReturnedKey.SymetricHostHalfKey), clientAsymetricKey.PrivateKey.KeyCspBlob);
        List<byte> fullSymetricKey = new List<byte>();
        fullSymetricKey.AddRange(clientSymetricKeyPart);
        fullSymetricKey.AddRange(serverSideSymetrycKeyPart);

        //Crypte call args
        string argumentJsonString = JsonConvert.SerializeObject(args, settings);

        SymetricCryptedData cryptedData = cryptoHelper.SymetricEncryptToBytes(argumentJsonString, fullSymetricKey.ToArray(), Encoding.UTF8);
        CryptedCallObject callCryptedObject = new CryptedCallObject()
        {
          Base64CryptedData = Convert.ToBase64String(cryptedData.EncryptedBytes),
          Base64IV = Convert.ToBase64String(cryptedData.IV),
          CallNode = publicKeyUiModel.NodeAnswered,
          KeyToken = keyExchangeReturnedKey.FullSymetricKeyToken
        };
        string callCryptedObjectJsonString = JsonConvert.SerializeObject(callCryptedObject, settings);


        //Perform the call
        StringContent jsonStringContentCallCryptedObject = new StringContent(callCryptedObjectJsonString, UnicodeEncoding.UTF8, "application/json");
        HttpResponseMessage callResponse = client.PostAsync(_siteUrl + "/Data/" + methodName, jsonStringContentCallCryptedObject).Result;
        string callResponseStringContent = callResponse.Content.ReadAsStringAsync().Result;

        if (callResponseStringContent.StartsWith("{\"CryptedBase64Data\""))
        {
          CryptedCallReturn callReturn = new CryptedCallReturn();
          JsonConvert.PopulateObject(callResponseStringContent, callReturn, settings);

          //Handle the call result
          SymetricCryptedData cryptedObject = new SymetricCryptedData()
          {
            EncryptedBytes = Convert.FromBase64String(callReturn.CryptedBase64Data),
            IV = callReturn.IV
          };

          string responseData = cryptoHelper.SymetricDecryptToString(cryptedObject, fullSymetricKey.ToArray(), Encoding.UTF8);


          JsonConvert.PopulateObject(responseData, response, settings);
        }
        else
        {
                    response.Errors.Add(new BaseServiceError()
                    {
                        ErrorCode = 500,
                        ErrorMessage = callResponseStringContent
                    });
                    response.HasError = true;
                    response.Messages = callResponseStringContent;
        }
      }
      else
      {
                response.Errors.Add(new BaseServiceError()
                {
                    ErrorCode = 500,
                    ErrorMessage = getPublicKeyContent
                });
                response.HasError = true;
                response.Messages = getPublicKeyContent;
            }

      return response;
    }
  }
}
