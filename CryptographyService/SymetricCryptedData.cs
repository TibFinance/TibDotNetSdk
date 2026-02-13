namespace Tib.Api.CryptographyService
{
  /// <summary>
  /// Object resulting from a symmetric encryption. Contains the encrypted data and the IV used for encryption.
  /// </summary>
  public class SymetricCryptedData
  {
    /// <summary>
    /// Creates a new instance of symmetrically encrypted data with IV
    /// </summary>
    public SymetricCryptedData()
    {

    }

    /// <summary>
    /// Data encrypted with a symmetric key
    /// </summary>
    public byte[] EncryptedBytes { get; set; }

    /// <summary>
    /// The IV is the random portion prepended to the message so that it cannot be recognized by association.
    /// </summary>
    public byte[] IV { get; set; }
  }
}
