
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
    /// Represents the data required to create a new bill in the TIB Finance system.
    /// </summary>
    /// <value>Encapsulates all bill attributes such as client identifier, amount, currency, due date, and descriptive metadata.</value>
    public BillEntity BillData { get; set; }

    /// <summary>
    /// Determines whether the function should return an error if the merchant has not been authorized. This boolean property ensures that unauthorized merchants are not processed further.
    /// </summary>
    /// <value>No specific input value is required for this property.</value>
    public bool BreakIfMerchantNeverBeenAuthorized { get; set; }

    }
}