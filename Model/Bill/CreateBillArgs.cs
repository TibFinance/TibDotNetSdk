
using System;
using Tib.Api.Model.Bill;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the CreateBillArgs model.
    /// </summary>
    public class CreateBillArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The bill details to be created by the CreateBill method.
    /// </summary>
    /// <value>Must be a non‑null BillEntity containing all required fields (e.g., amount, currency, dueDate, payerId). Values must pass validation rules: amount &gt; 0, dueDate in the future, and identifiers must reference existing entities.</value>
    public BillEntity BillData { get; set; }

    /// <summary>
    /// When true, the call is refused before anything is created if the merchant is not authorized or has no bank account: it answers ErrorCode 500 with "Merchant is not authorized or has no valid banking informations." False by default. For a merchant that is not authorized, a client or service session is refused with "Unauthorized" whatever this value.
    /// </summary>
    public bool BreakIfMerchantNeverBeenAuthorized { get; set; }

    }
}