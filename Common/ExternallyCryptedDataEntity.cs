
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ExternallyCryptedDataEntity model.
    /// </summary>
    public class ExternallyCryptedDataEntity 
    {
        
    /// <summary>
    /// Gets or sets the external key identifier.
    /// </summary>
    /// <value>The external key identifier.</value>
    public Guid ExternalKeyId { get; set; }

    /// <summary>
    /// Gets or sets the external vault identifier.
    /// </summary>
    /// <value>The external vault identifier.</value>
    public Guid ExternalVaultId { get; set; }

    /// <summary>
    /// Gets or sets the encryption iv.
    /// </summary>
    /// <value>The encryption iv.</value>
    public Guid EncryptionIV { get; set; }

    /// <summary>
    /// Gets or sets the crypted data part1.
    /// </summary>
    /// <value>The crypted data part1.</value>
    public string CryptedDataPart1 { get; set; }

    }
}