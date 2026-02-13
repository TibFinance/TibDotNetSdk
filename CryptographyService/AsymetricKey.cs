namespace Tib.Api.CryptographyService
{
  /// <summary>
  /// Contains both the public and private keys
  /// </summary>
  public class AsymetricKey
  {
    /// <summary>
    /// Creates a new asymmetric key pair instance
    /// </summary>
    public AsymetricKey()
    {
    }

    /// <summary>
    /// Public key (CspBlob)
    /// </summary>
    public RsaPublicKey PublicKey { get; set; }
    public string PublicPEMKey { get; set; }

    /// <summary>
    /// Private key (CspBlob)
    /// </summary>
    public RsaPrivateKey PrivateKey { get; set; }
  }
}
