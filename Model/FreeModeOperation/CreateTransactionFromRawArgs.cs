
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
    /// Raw ACP (Automated Clearing and Payment) file content to parse and process.
    /// </summary>
    public string RawAcpFileContent { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// When true, deposit lines from the file are sent through the ARN instant-deposit rail instead of standard EFT. The upload is refused if the file contains any collection lines, any recurring lines, or if the merchant currency is not CAD. Optional; absent or false keeps standard EFT behavior.
    /// </summary>
    public bool? IsImmediate { get; set; }

    }
}