
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the RecuringTransferModel model.
    /// </summary>
    public class RecuringTransferModel 
    {
        
    /// <summary>
    /// The date and time when the next recurring transfer is scheduled to occur.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always a future date for active schedules, null if no further occurrences are planned.</value>
    public DateTime NextRecuringDate { get; set; }

    /// <summary>
    /// Identifier of the recurring transfer to delete
    /// </summary>
    /// <value>Guid; must reference an existing active recurring transfer; required and immutable</value>
    public Guid RecuringTransferId { get; set; }

    /// <summary>
    /// Specifies the frequency at which the transfer recurs.
    /// </summary>
    /// <value>Enum TransferFrequencyEnum (e.g., DAILY, WEEKLY, MONTHLY, YEARLY). Present only for recurring transfers; omitted or null for one‑off transfers.</value>
    public TransferFrequencyEnum RecuringMode { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Identifier of the payment method linked to the recurring transfer.
    /// </summary>
    /// <value>A valid GUID referencing the associated payment method; may be null if the transfer is not tied to a specific method. Must conform to standard GUID format.</value>
    public Guid? RelatedPaymentMethodId { get; set; }

    /// <summary>
    /// The reference date from which the recurring transfer schedule is calculated.
    /// </summary>
    /// <value>ISO‑8601 UTC datetime; read‑only; must be a valid, non‑null date; serves as the base for all recurrence intervals (e.g., weekly, monthly).</value>
    public DateTime RecuringRefDate { get; set; }

    /// <summary>
    /// Date and time this recurring transfer was created.
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Unique identifier of the merchant linked to the recurring transfer.
    /// </summary>
    /// <value>Guid; present only when the transfer is associated with a merchant, otherwise null. Read‑only and must be a valid GUID.</value>
    public Guid RelatedMerchantId { get; set; }

    /// <summary>
    /// The name of the merchant linked to the recurring transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be null if the transfer has no associated merchant; trimmed of leading/trailing whitespace.</value>
    public string RelatedMerchantName { get; set; }

    /// <summary>
    /// Name of the customer for this recurring transfer (empty if the customer record was deleted). For supplier transfers the paying merchant is represented as a customer of the supplier, so this carries the paying merchant's name as snapshotted when that customer record was created — later merchant renames do not propagate here.
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// The descriptive title of the recurring transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may include letters, numbers, spaces and common punctuation; used for display and identification in UI and reports.</value>
    public string TrasnferTitle { get; set; }

    /// <summary>
    /// A textual description of the recurring transfer.
    /// </summary>
    /// <value>Optional string, up to 255 characters; may include alphanumeric characters, spaces, and common punctuation; returned exactly as stored.</value>
    public string TrasnferDescription { get; set; }

    /// <summary>
    /// Identifier assigned by the external system for the recurring transfer
    /// </summary>
    /// <value>String, up to 50 alphanumeric characters; may be empty if the external system did not provide an ID</value>
    public string TrasnferExternalSystemNumber { get; set; }

    /// <summary>
    /// The date on which the recurring transfer series terminates.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; must be later than the transfer's StartDate. May be null to indicate an indefinite series. The date is inclusive—last scheduled transfer occurs on this day.</value>
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// True when this recurring schedule is a supplier transfer (the supplier receives funds and a separate paying merchant is billed).
    /// </summary>
    public bool IsSupplierTransfer { get; set; }

    /// <summary>
    /// Display name of the merchant that pays for the supplier transfer. Populated only by GetRecuringTransfers, and only when the recurring transfer is a supplier transfer whose fee-paying merchant still resolves. Always null on ListSupplierRecurringTransfers and ListSupplierRecurringTransfersByService — on those listings the paying merchant surfaces as CustomerName instead.
    /// </summary>
    public string PayerMerchantName { get; set; }

    /// <summary>
    /// True when the caller is on the paying side of this transfer. ListSupplierRecurringTransfers and ListSupplierRecurringTransfersByService always return true — their rows list transfers from the paying side by construction. GetRecuringTransfers computes it: false when the caller is the supplier-side recipient of a transfer paid by another merchant. Rows where this is false are informational — the server rejects attempts to update or delete them.
    /// </summary>
    public bool IsCurrentUserPayer { get; set; }

    }
}