
using System;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the GetSupplierTransferResponse model.
    /// </summary>
    public class GetSupplierTransferResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The payment details associated with each recurring transfer returned by GetRecuringTransfers.
    /// </summary>
    /// <value>Contains amount, currency, execution date, and status of the scheduled payment; may be null if the transfer has no associated payment.</value>
    public PaymentModel Payment { get; set; }

    /// <summary>
    /// The supplier's merchant name (for payer view) or the payer's merchant name (for supplier view).
    /// </summary>
    public string CounterpartyName { get; set; }

    /// <summary>
    /// True if the caller is the fee-payer, false if caller is the supplier.
    /// </summary>
    public bool IsCallerPayer { get; set; }

    /// <summary>
    /// The payer's custom alias for the supplier (from MerchantSuppliers.SupplierName).
    /// </summary>
    public string SupplierAlias { get; set; }

    }
}