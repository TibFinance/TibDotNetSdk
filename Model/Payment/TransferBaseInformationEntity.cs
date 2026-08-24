
using System;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the TransferBaseInformationEntity model.
    /// </summary>
    public class TransferBaseInformationEntity 
    {
        
    /// <summary>
    /// Transfer id.
    /// </summary>
    public Guid i { get; set; }

    /// <summary>
    /// Creation date (UTC). Only populated on ListSupplierTransfers.
    /// </summary>
    public DateTime cdt { get; set; }

    /// <summary>
    /// Display label of the paying payment method (for example the card brand and its last digits).
    /// </summary>
    public string t { get; set; }

    /// <summary>
    /// Payment method type, as a PaymentMethodTypeEnum integer value.
    /// </summary>
    public int pmt { get; set; }

    /// <summary>
    /// Masked account preview of the paying payment method.
    /// </summary>
    public string d { get; set; }

    /// <summary>
    /// Merchant name.
    /// </summary>
    public string m { get; set; }

    /// <summary>
    /// Transfer due date (UTC).
    /// </summary>
    public DateTime td { get; set; }

    /// <summary>
    /// Transfer amount. On ListSupplierTransfers this is the operation amount when available, otherwise the transfer amount.
    /// </summary>
    public decimal a { get; set; }

    /// <summary>
    /// Composed process status, as a ProcessStatusEnum integer value. Defaults to New (1) when no status is available.
    /// </summary>
    public int s { get; set; }

    /// <summary>
    /// Raw transfer status (ProcessStatusEnum value), taken directly from the transfer record; not reliably updated on all paths — prefer s, the composed status. Always 0 on ListTransfersForBillFast.
    /// </summary>
    public int ts { get; set; }

    /// <summary>
    /// Customer-facing status label. Only populated on ListSupplierTransfers. One of: Pending, InProgress, Completed, RevertedPending, RevertedCompleted, Error, Canceled.
    /// </summary>
    public string cps { get; set; }

    /// <summary>
    /// Bank return code, as a BankingOperationResultEnum integer value.
    /// </summary>
    public int c { get; set; }

    /// <summary>
    /// Customer name.
    /// </summary>
    public string cn { get; set; }

    /// <summary>
    /// Customer email. Only populated on ListSupplierTransfers.
    /// </summary>
    public string cem { get; set; }

    /// <summary>
    /// Customer id. Only populated on ListSupplierTransfers.
    /// </summary>
    public Guid cid { get; set; }

    /// <summary>
    /// Bank-side transaction description. Only populated on ListSupplierTransfers.
    /// </summary>
    public string trd { get; set; }

    /// <summary>
    /// The merchant's own deposit account label. Not populated on ListTransfersForBillFast.
    /// </summary>
    public string man { get; set; }

    /// <summary>
    /// The merchant's own deposit account preview (masked). Not populated on ListTransfersForBillFast.
    /// </summary>
    public string map { get; set; }

    /// <summary>
    /// Execution date (UTC). Not populated on ListTransfersForBillFast.
    /// </summary>
    public DateTime ed { get; set; }

    /// <summary>
    /// True when the transfer has no payment method attached and its payment link is missing or expired — the payer can no longer complete it without a new link.
    /// </summary>
    public bool he { get; set; }

    /// <summary>
    /// Transfer direction (collection or deposit).
    /// </summary>
    public int Direction { get; set; }

    /// <summary>
    /// Original dollar amount of the transfer.
    /// </summary>
    public decimal TransferAmount { get; set; }

    /// <summary>
    /// Whether this transfer is a supplier payment.
    /// </summary>
    public bool IsSupplierTransfer { get; set; }

    /// <summary>
    /// The payer's custom alias for the supplier (from MerchantSuppliers.SupplierName). Only populated for supplier transfer list endpoints.
    /// </summary>
    public string SupplierAlias { get; set; }

    /// <summary>
    /// The customer's external reference number.
    /// </summary>
    public string ern { get; set; }

    }
}