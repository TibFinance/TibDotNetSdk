
using System;
using Tib.Api.Model.Bill;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateBillAdvancedArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Represents the data required to create a new bill in the TIB Finance system.
    /// </summary>
    /// <value>Encapsulates all bill attributes such as client identifier, amount, currency, due date, and descriptive metadata.</value>
    public BillEntityAdvanced BillData { get; set; }

    /// <summary>
    /// Determines whether the function should return an error if the merchant has not been authorized. This boolean property ensures that unauthorized merchants are not processed further.
    /// </summary>
    /// <value>No specific input value is required for this property.</value>
    public bool BreakIfMerchantNeverBeenAuthorized { get; set; }

    /// <summary>
    /// If true, the system will automatically calculate totals from line items. If false, use the BillAmount from BillData as the total. Default: true when Lines are provided, false otherwise.
    /// </summary>
    /// <value></value>
    public bool? AutoCalculateTotals { get; set; }

    /// <summary>
    /// If true, the system will automatically generate an invoice number using the merchant's sequence. If false and InvoiceNumber is not provided, no invoice number will be assigned. Default: true
    /// </summary>
    /// <value></value>
    public bool AutoGenerateInvoiceNumber { get; set; }

    /// <summary>
    /// If true and the invoice is marked as Sent status, an email will be sent to the billing email. Default: false
    /// </summary>
    /// <value></value>
    public bool SendEmailOnCreate { get; set; }

    }
}