
namespace Tib.Api.CryptographyService
{
  public class RsaPrivateKey : RsaPublicKey
  {
    public RsaPrivateKey()
    {

    }

    /// <summary>
    /// The "D" parameter
    /// </summary>
    public byte[] PrivateExponent { get; set; }

    /// <summary>
    /// The "DP" parameter
    /// </summary>
    public byte[] Exponent1 { get; set; }

    /// <summary>
    /// The "DQ" parameter
    /// </summary>
    public byte[] Exponent2 { get; set; }

    /// <summary>
    /// The "inverse of q" mod p parameter
    /// </summary>
    public byte[] Coefficient { get; set; }

    /// <summary>
    /// The "P" parameter
    /// </summary>
    public byte[] Prime1 { get; set; }

    /// <summary>
    /// The "Q" parameter
    /// </summary>
    public byte[] Prime2 { get; set; }
  }
}
