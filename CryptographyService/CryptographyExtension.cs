using System.Text;

namespace Tib.Api.CryptographyService
{
  public static class CryptographyExtension
  {
    public static string HashStringToHexString(this string origin, string salt, ShaTypeEnum shaType = ShaTypeEnum.SHA512)
    {
      Cryptography crypto = new Cryptography();
      byte[] crypted = crypto.Hash(origin, salt, shaType);
      return ByteArrayToString(crypted);
    }

    private static string ByteArrayToString(byte[] ba)
    {
      StringBuilder hex = new StringBuilder(ba.Length * 2);
      foreach (byte b in ba)
      {
        hex.AppendFormat("{0:x2}", b);
      }
      return hex.ToString();
    }
  }
}
