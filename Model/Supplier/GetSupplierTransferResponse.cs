
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
    /// <value></value>
    public string CounterpartyName { get; set; }

    /// <summary>
    /// True if the caller is the fee-payer, false if caller is the supplier.
    /// </summary>
    /// <value></value>
    public bool IsCallerPayer { get; set; }

    /// <summary>
    /// The payer's custom alias for the supplier (from MerchantSuppliers.SupplierName).
    /// </summary>
    /// <value></value>
    public string SupplierAlias { get; set; }

    }
}