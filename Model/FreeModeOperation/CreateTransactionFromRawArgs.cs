
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
    /// <value></value>
    public string RawAcpFileContent { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// When true, deposit lines from the file are sent through the ARN instant-deposit rail instead of standard EFT. The upload is refused if the file contains any collection lines, any recurring lines, or if the merchant currency is not CAD. Optional; absent or false keeps standard EFT behavior.
    /// </summary>
    /// <value></value>
    public bool? IsImmediate { get; set; }

    }
}