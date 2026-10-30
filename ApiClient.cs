// ***********************************************************************
// Assembly         : Tib.Api
// Author           : cboivin
// Created          : 05-15-2019
//
// Last Modified By : cboivin
// Last Modified On : 05-15-2019
// Last Modified By : TIB Finance
// Last Modified On : 04-12-2021
// ***********************************************************************
// <copyright file="ApiClient.cs" company="Tib.finance">
//     Copyright ©  2026
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
using System.Text.RegularExpressions;
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
    /// The shared HTTP client
    /// </summary>
    private static readonly HttpClient _httpClient;

    /// <summary>
    /// How many characters of a non-API reply the error message keeps
    /// </summary>
    private const int ReplyStartLength = 300;

    /// <summary>
    /// Initializes static members of the <see cref="ApiClient"/> class.
    /// </summary>
    static ApiClient()
    {
      // The API requires TLS 1.2; projects targeting .NET Framework < 4.7 default to older protocols
      System.Net.ServicePointManager.SecurityProtocol |= System.Net.SecurityProtocolType.Tls12;
      _httpClient = new HttpClient();
      _httpClient.Timeout = TimeSpan.FromMinutes(5);
      _httpClient.DefaultRequestHeaders.Add("TIB_API_Version", "0.2");
    }

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

      JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.None };

      //GetPublicKey
      HttpResponseMessage getPublicKeyResponse = _httpClient.PostAsync(_siteUrl + "/Data/GetPublicKey", new StringContent("", UnicodeEncoding.UTF8, "application/json")).Result;
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
        HttpResponseMessage executeKeyExchangeResponse = _httpClient.PostAsync(_siteUrl + "/Data/ExecuteKeyExchange", jsonStringContentKeyExchangeArgs).Result;
        string executeKeyExchangeContent = executeKeyExchangeResponse.Content.ReadAsStringAsync().Result;
        KeyExchangeReturnedKey keyExchangeReturnedKey = ReadKeyExchangeReply(executeKeyExchangeContent, settings);
        if (keyExchangeReturnedKey == null)
        {
          SetReplyError(response, executeKeyExchangeResponse, executeKeyExchangeContent);
          return response;
        }

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
        HttpResponseMessage callResponse = _httpClient.PostAsync(_siteUrl + "/Data/" + methodName, jsonStringContentCallCryptedObject).Result;
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
          SetReplyError(response, callResponse, callResponseStringContent);
        }
      }
      else
      {
        SetReplyError(response, getPublicKeyResponse, getPublicKeyContent);
      }

      return response;
    }

    /// <summary>
    /// Reads the reply of the key exchange.
    /// </summary>
    /// <param name="content">The body of the reply.</param>
    /// <param name="settings">The JSON settings.</param>
    /// <returns>The returned key, or null when the reply is not the API's (for example a web-server or proxy error page).</returns>
    private static KeyExchangeReturnedKey ReadKeyExchangeReply(string content, JsonSerializerSettings settings)
    {
      KeyExchangeReturnedKey keyExchangeReturnedKey = new KeyExchangeReturnedKey();
      try
      {
        JsonConvert.PopulateObject(content, keyExchangeReturnedKey, settings);
      }
      catch (JsonException)
      {
        return null;
      }

      if (string.IsNullOrEmpty(keyExchangeReturnedKey.SymetricHostHalfKey))
      {
        return null;
      }

      return keyExchangeReturnedKey;
    }

    /// <summary>
    /// Sets the error of a reply that is not the API's: a web-server, proxy or gateway error page, or an empty reply.
    /// The error carries the HTTP status and the start of the reply.
    /// </summary>
    /// <param name="response">The response.</param>
    /// <param name="httpResponse">The HTTP reply.</param>
    /// <param name="content">The body of the reply.</param>
    private static void SetReplyError(ClientBaseResponse response, HttpResponseMessage httpResponse, string content)
    {
      string message = "HTTP " + (int)httpResponse.StatusCode;
      if (!string.IsNullOrWhiteSpace(httpResponse.ReasonPhrase))
      {
        message += " " + httpResponse.ReasonPhrase.Trim();
      }

      string replyStart = Regex.Replace(content ?? "", @"\s+", " ").Trim();
      if (replyStart.Length > ReplyStartLength)
      {
        int length = char.IsHighSurrogate(replyStart[ReplyStartLength - 1]) ? ReplyStartLength - 1 : ReplyStartLength;
        replyStart = replyStart.Substring(0, length) + "...";
      }
      if (replyStart.Length > 0)
      {
        message += ": " + replyStart;
      }

      if (response.Errors == null)
      {
        response.Errors = new List<BaseServiceError>();
      }
      response.Errors.Add(new BaseServiceError()
      {
        ErrorCode = 500,
        ErrorMessage = message
      });
      response.HasError = true;
      response.Messages = message;
    }
  }
}
