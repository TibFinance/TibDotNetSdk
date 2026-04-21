
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
    /// Indicates whether bill creation should abort if the merchant has never been authorized.
    /// </summary>
    /// <value>Boolean flag; true stops the operation when the merchant lacks prior authorization, false proceeds. Defaults to false if omitted.</value>
    public bool BreakIfMerchantNeverBeenAuthorized { get; set; }

    }
}