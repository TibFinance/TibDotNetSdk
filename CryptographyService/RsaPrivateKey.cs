
namespace Tib.Api.CryptographyService
{
  public class RsaPrivateKey : RsaPublicKey
  {
    public RsaPrivateKey()
    {

    }

    /// <summary>
    /// Paramêtre "D"
    /// </summary>
    public byte[] PrivateExponent { get; set; }

    /// <summary>
    /// Paramètre "DP"
    /// </summary>
    public byte[] Exponent1 { get; set; }

    /// <summary>
    /// Paramètre "DQ"
    /// </summary>
    public byte[] Exponent2 { get; set; }

    /// <summary>
    /// Paramètre "inverse of q" mod p
    /// </summary>
    public byte[] Coefficient { get; set; }

    /// <summary>
    /// Paramètre "P"
    /// </summary>
    public byte[] Prime1 { get; set; }

    /// <summary>
    /// Paramètre "Q"
    /// </summary>
    public byte[] Prime2 { get; set; }
  }
}
