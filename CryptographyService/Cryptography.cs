using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Tib.Api.CryptographyService.MyProject.Data.Encryption;

namespace Tib.Api.CryptographyService
{
  public class Cryptography
  {
    public Cryptography()
    {
    }


    public SymetricCryptedData SymetricEncryptToBytes(string decryptedData, byte[] key, Encoding encoding = null, Guid? fixedIV = null)
    {
      if (encoding == null)
      {
        encoding = GetDefaultEncoding();
      }

      return SymetricEncryptToBytes(encoding.GetBytes(decryptedData), key, fixedIV);
    }

    public SymetricCryptedData SymetricEncryptToBytes(byte[] decryptedData, byte[] key, Guid? fixedIV = null)
    {
      SymetricCryptedData cryptedDataObject = new SymetricCryptedData();

      if (fixedIV.HasValue)
      {
        cryptedDataObject.IV = fixedIV.Value.ToByteArray();
      }
      else
      {
        cryptedDataObject.IV = Guid.NewGuid().ToByteArray();
      }

      RijndaelManaged provider = CreateSymetricProvider(key);
      provider.IV = cryptedDataObject.IV;

      // Create a decryptor to perform the stream transform.
      ICryptoTransform encryptor = provider.CreateEncryptor(provider.Key, provider.IV);

      // Create the streams used for encryption. 
      using (MemoryStream msEncrypt = new MemoryStream())
      {
        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
        {
          using (BinaryWriter swEncrypt = new BinaryWriter(csEncrypt))
          {
            //Write all data to the stream.
            swEncrypt.Write(decryptedData);
          }
          cryptedDataObject.EncryptedBytes = msEncrypt.ToArray();
        }
      }


      // Return the encrypted bytes from the memory stream. 
      return cryptedDataObject;
    }



    public string SymetricDecryptToString(SymetricCryptedData cryptedObject, byte[] key, Encoding encoding = null, Guid? fixedIV = null)
    {
      if (encoding == null)
      {
        encoding = GetDefaultEncoding();
      }

      byte[] decryptedBytes = SymetricDecryptToBytes(cryptedObject, key, fixedIV);

      return encoding.GetString(decryptedBytes);
    }

    public byte[] SymetricDecryptToBytes(SymetricCryptedData cryptedObject, byte[] key, Guid? fixedIV = null)
    {
      // Declare the byte[] used to hold 
      // the decrypted text. 
      List<byte> returnDecryptedByteList = new List<byte>();

      RijndaelManaged provider = CreateSymetricProvider(key);

      if (fixedIV.HasValue)
      {
        provider.IV = fixedIV.Value.ToByteArray();
      }
      else
      {
        provider.IV = cryptedObject.IV;
      }

      // Create a decrytor to perform the stream transform.
      ICryptoTransform decryptor = provider.CreateDecryptor(provider.Key, provider.IV);

      // Create the streams used for decryption. 
      using (MemoryStream encryptedBytesStream = new MemoryStream(cryptedObject.EncryptedBytes))
      {
        using (CryptoStream encryptorStream = new CryptoStream(encryptedBytesStream, decryptor, CryptoStreamMode.Read))
        {
          using (MemoryStream decryptedBytesStream = new MemoryStream())
          {
            encryptorStream.CopyTo(decryptedBytesStream);
            decryptedBytesStream.Position = 0;
            using (BinaryReader byteStreamReader = new BinaryReader(decryptedBytesStream))
            {
              for (int i = 0; i < decryptedBytesStream.Length; i++)
              {
                returnDecryptedByteList.Add(byteStreamReader.ReadByte());
              }
            }
          }
        }
      }

      return returnDecryptedByteList.ToArray();
    }

    public AsymetricKey AsymetricGetKey(int keySize = 1024, bool includePrivate = true)
    {
      return ExportAsymetricKey(CreateRsaProvider(keySize), includePrivate);
    }

    public AsymetricKey AsymetricGetKey(byte[] keyCspBlob, bool includePrivate = true)
    {
      return ExportAsymetricKey(CreateRsaProviderFromBlob(keyCspBlob), includePrivate);
    }

    /// <summary>
    /// This method will load a PEM key or a XML key
    /// </summary>
    /// <param name="stringKey"></param>
    /// <param name="includePrivate"></param>
    /// <returns></returns>
    public AsymetricKey AsymetricGetKey(string stringKey, bool includePrivate = true)
    {
      RSACryptoServiceProvider rsa;
      if (stringKey.StartsWith("<RSAKeyValue>"))
      {
        rsa = CreateRsaProviderFromXml(stringKey);
      }
      else
      {
        if (includePrivate)
        {
          rsa = PEMCrypto.ImportPrivateKey(stringKey);
        }
        else
        {
          rsa = PEMCrypto.ImportPublicKey(stringKey);
        }
      }
      return ExportAsymetricKey(rsa, includePrivate);
    }

    private AsymetricKey ExportAsymetricKey(RSACryptoServiceProvider rsaProvider, bool includePrivate)
    {
      var parameters = rsaProvider.ExportParameters(includePrivate);

      AsymetricKey key = new AsymetricKey();
      if (includePrivate)
      {
        key.PrivateKey = new RsaPrivateKey()
        {
          KeyCspBlob = rsaProvider.ExportCspBlob(true),
          KeyXmlString = rsaProvider.ToXmlString(true),
          Modulus = parameters.Modulus,
          PublicExponent = parameters.Exponent,
          Coefficient = parameters.InverseQ,
          Exponent1 = parameters.DP,
          Exponent2 = parameters.DQ,
          Prime1 = parameters.P,
          Prime2 = parameters.Q,
          PrivateExponent = parameters.D
        };
      }

      key.PublicKey = new RsaPublicKey()
      {
        KeyCspBlob = rsaProvider.ExportCspBlob(false),
        KeyXmlString = rsaProvider.ToXmlString(false),
        Modulus = parameters.Modulus,
        PublicExponent = parameters.Exponent,
      };
      key.PublicPEMKey = PEMCrypto.ExportPublicKey(rsaProvider);

      return key;
    }

    public byte[] AsymetricEncryptToBytes(string decryptedData, byte[] keyCspBlob, Encoding encoding = null)
    {
      if (encoding == null)
      {
        encoding = GetDefaultEncoding();
      }

      return AsymetricEncryptToBytes(encoding.GetBytes(decryptedData), keyCspBlob);
    }

    public byte[] AsymetricEncryptToBytes(byte[] decryptedData, byte[] keyCspBlob)
    {
      return CreateRsaProviderFromBlob(keyCspBlob).Encrypt(decryptedData, false);
    }

    public string AsymetricDecryptToString(byte[] cryptedData, byte[] keyCspBlob, Encoding encoding = null)
    {
      if (encoding == null)
      {
        encoding = GetDefaultEncoding();
      }

      byte[] decryptedBytes = AsymetricDecryptToBytes(cryptedData, keyCspBlob);

      return encoding.GetString(decryptedBytes);
    }

    public byte[] AsymetricDecryptToBytes(byte[] cryptedData, byte[] keyCspBlob)
    {
      return CreateRsaProviderFromBlob(keyCspBlob).Decrypt(cryptedData, false);
    }


    private RSACryptoServiceProvider CreateRsaProviderFromBlob(byte[] keyCspBlob)
    {
      int keySize = (keyCspBlob.Length - 20) * 8;

      RSACryptoServiceProvider rsaProvider = CreateRsaProvider(keySize);
      rsaProvider.ImportCspBlob(keyCspBlob);
      return rsaProvider;
    }

    private RSACryptoServiceProvider CreateRsaProviderFromXml(string keyXml)
    {
      CspParameters cpsParameter = new CspParameters();
      cpsParameter.ProviderType = 1;

      RSACryptoServiceProvider rsaProvider = new RSACryptoServiceProvider(cpsParameter);
      rsaProvider.FromXmlString(keyXml);
      return rsaProvider;
    }

    private RSACryptoServiceProvider CreateRsaProvider(int keySize)
    {
      CspParameters cpsParameter = new CspParameters();
      cpsParameter.ProviderType = 1;

      return new RSACryptoServiceProvider(keySize, cpsParameter);
    }

    private RijndaelManaged CreateSymetricProvider(byte[] key)
    {
      return new RijndaelManaged()
      {
        BlockSize = 128,
        Key = key
      };
    }

    private Encoding GetDefaultEncoding()
    {
      return Encoding.UTF8;
    }

    public byte[] GetRandomSalt(int length = 64)
    {
      return GetDefaultEncoding().GetBytes(GetRandomSaltString(length));
    }

    public string GetRandomSaltString(int length = 64)
    {
      return Randomizer.GetRandomString(length, RandomCodeTypeEnum.LettersAndNumbers);
    }

    public byte[] Hash(string stringToHash, byte[] salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      return Hash(GetDefaultEncoding().GetBytes(stringToHash), salt, shaType);
    }

    public string HashFileToString(string filePath, byte[] salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      if (File.Exists(filePath))
      {
        return HashToString(File.ReadAllBytes(filePath), salt, shaType);
      }
      return null;

    }
    public string HashToString(string stringToHash, byte[] salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      return HashToString(Encoding.UTF8.GetBytes(stringToHash), salt, shaType);
    }

    public string HashToString(byte[] bytesToHash, byte[] salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      byte[] hash = Hash(bytesToHash, salt, shaType);
      if (hash != null)
      {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < hash.Length; i++)
        {
          sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString();
      }
      return string.Empty;
    }

    public byte[] Hash(byte[] bytesToHash, byte[] salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      HashAlgorithm hasher = null;
      switch (shaType)
      {
        case ShaTypeEnum.SHA1:
          if (salt != null)
          {
            hasher = new HMACSHA1(salt);
          }
          else
          {
            hasher = SHA1.Create();
          }
          break;
        case ShaTypeEnum.SHA256:
          if (salt != null)
          {
            hasher = new HMACSHA256(salt);
          }
          else
          {
            hasher = SHA256.Create();
          }
          break;
        case ShaTypeEnum.SHA384:
          if (salt != null)
          {
            hasher = new HMACSHA384(salt);
          }
          else
          {
            hasher = SHA384.Create();
          }
          break;
        case ShaTypeEnum.SHA512:
          if (salt != null)
          {
            hasher = new HMACSHA512(salt);
          }
          else
          {
            hasher = SHA512.Create();
          }
          break;
        default:
          throw new NotSupportedException("Not implemented ShaTypeEnum value");
      }

      return hasher.ComputeHash(bytesToHash);
    }


    public byte[] Hash(string stringToHash, string salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      return Hash(stringToHash, GetDefaultEncoding().GetBytes(salt), shaType);
    }

    public byte[] Hash(byte[] bytesToHash, string salt = null, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      return Hash(bytesToHash, GetDefaultEncoding().GetBytes(salt), shaType);
    }


    public byte[] Hash(string stringToHash, out byte[] salt, int saltLength = 64, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      salt = GetRandomSalt(saltLength);
      return Hash(stringToHash, salt, shaType);
    }

    public byte[] Hash(byte[] bytesToHash, out byte[] salt, int saltLength = 64, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      salt = GetRandomSalt(saltLength);
      return Hash(bytesToHash, salt, shaType);
    }

    public byte[] Hash(string stringToHash, out string salt, int saltLength = 64, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      salt = GetRandomSaltString(saltLength);
      return Hash(stringToHash, salt, shaType);
    }

    public byte[] Hash(byte[] bytesToHash, out string salt, int saltLength = 64, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      salt = GetRandomSaltString(saltLength);
      return Hash(bytesToHash, salt, shaType);
    }
  }
}
