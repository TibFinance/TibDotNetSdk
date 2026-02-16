namespace Tib.Api.CryptographyService
{
  public class RsaPublicKey
  {
    public RsaPublicKey()
    {

    }

    public byte[] KeyCspBlob { get; set; }

    public string KeyXmlString { get; set; }

    /// <summary>
    /// The "exponent" parameter
    /// </summary>
    public byte[] PublicExponent { get; set; }

    /// <summary>
    /// The "n" parameter
    /// </summary>
    public byte[] Modulus { get; set; }
  }
}
