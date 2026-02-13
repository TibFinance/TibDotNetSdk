namespace Tib.Api.CryptographyService
{
  /// <summary>
  /// Contient les deux clefs "publique" et privée"
  /// </summary>
  public class AsymetricKey
  {
    /// <summary>
    /// Crée une nouvelle instancede clefs asymétrique
    /// </summary>
    public AsymetricKey()
    {
    }

    /// <summary>
    /// Clef publique (CspBlob)
    /// </summary>
    public RsaPublicKey PublicKey { get; set; }
    public string PublicPEMKey { get; set; }

    /// <summary>
    /// Clef privé (CspBlob)
    /// </summary>
    public RsaPrivateKey PrivateKey { get; set; }
  }
}
