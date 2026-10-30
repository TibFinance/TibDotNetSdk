
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
    /// The payment file to upload, as text: our semicolon-separated format, the Payments Canada CPA Standard 005 format or the 80-character EFT export of Sage 50.
    /// </summary>
    public string RawAcpFileContent { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// When true, the deposits in this file become instant deposits. Additional fees may apply. Deposits only, one-time, dated today or earlier (UTC): the upload is refused if the file contains a collection line, a recurring line or a deposit dated after today, or if the merchant's currency is not CAD. Optional: absent or false keeps the usual schedule.
    /// </summary>
    public bool? IsImmediate { get; set; }

    }
}