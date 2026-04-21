
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the CreateFreeOperationArgs model.
    /// </summary>
    public class CreateFreeOperationArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid? BillId { get; set; }

    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Identifier of the payment method to be set as the default for the account
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID referencing an existing, active payment method owned by the caller; cannot be null or belong to another tenant.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Merchant-defined reference number for tracking this operation.
    /// </summary>
    /// <value></value>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// The scheduled date and time when the listed transfer is due to be executed.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp. Must be a future date for pending transfers; may be null for immediate or completed transfers.</value>
    public DateTime? TransactionDueDate { get; set; }

    /// <summary>
    /// Title or label for the transfer, displayed in reports.
    /// </summary>
    /// <value></value>
    public string TransferTitle { get; set; }

    /// <summary>
    /// Description or memo attached to the transfer.
    /// </summary>
    /// <value></value>
    public string TransferDescription { get; set; }

    /// <summary>
    /// External system reference number for cross-system tracking.
    /// </summary>
    /// <value></value>
    public string TransferExternalSystemNumber { get; set; }

    /// <summary>
    /// Specifies how often the payment should be executed.
    /// </summary>
    /// <value>Accepts a TransferFrequencyEnum value (e.g., ONE_TIME, DAILY, WEEKLY, MONTHLY, YEARLY). Required for recurring payments; defaults to ONE_TIME if omitted.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// End date for a recurring transfer. Null means no end date.
    /// </summary>
    /// <value></value>
    public DateTime? RecurringEndDate { get; set; }

    /// <summary>
    /// Identifier of the payment group to which the payment belongs
    /// </summary>
    /// <value>String, required, non‑empty, max 36 characters, must be a valid UUID/GUID if the system uses GUIDs</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Indicates whether the payment should be executed as an immediate transfer.
    /// </summary>
    /// <value>True triggers real‑time settlement; false creates a pending payment. Must be a boolean; ignored if the account lacks sufficient funds or if immediate processing is not supported for the selected currency.</value>
    public bool? ImmediateTransfer { get; set; }

    /// <summary>
    /// The text that will appear on the payer’s bank statement for this payment.
    /// </summary>
    /// <value>String, up to 140 characters; may include alphanumeric characters and basic punctuation; trimmed of leading/trailing whitespace; must not contain line breaks or special symbols that banks reject.</value>
    public string StatementDescription { get; set; }

    /// <summary>
    /// Whether to reject duplicate transfers with the same identification details.
    /// </summary>
    /// <value></value>
    public bool? StopSameIdentifications { get; set; }

    }
}