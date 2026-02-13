namespace Tib.Api.CryptographyService
{
  /// <summary>
  /// Object résultant d'une encryption symétrique. Possède les données encryptés et le IV utilisé pour l'encryption.
  /// </summary>
  public class SymetricCryptedData
  {
    /// <summary>
    /// Crée une nouvelle instance de données ayant été crypté de manière symétrique avec IV
    /// </summary>
    public SymetricCryptedData()
    {

    }

    /// <summary>
    /// Données encrypté avec une clef symétrique
    /// </summary>
    public byte[] EncryptedBytes { get; set; }

    /// <summary>
    /// Le IV est la portion "aléatoire" mis en avant du mesage afin que celui-ci ne puisse être reconnu par association.
    /// </summary>
    public byte[] IV { get; set; }
  }
}
