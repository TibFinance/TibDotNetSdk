
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the CreateTransactionFromRawArgs model.
    /// </summary>
    public class CreateTransactionFromRawArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the content of the raw ACP file.
    /// </summary>
    /// <value>Represents the data contained within the raw ACP file.</value>
    public string RawAcpFileContent { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}