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
    /// Paramètre "exponent"
    /// </summary>
    public byte[] PublicExponent { get; set; }

    /// <summary>
    /// Paramètre "n"
    /// </summary>
    public byte[] Modulus { get; set; }
  }
}
