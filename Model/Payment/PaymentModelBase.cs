
using System;
using Tib.Api.Model.Payment;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentModelBase model.
    /// </summary>
    public class PaymentModelBase 
    {
        
    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// External system's primary bill identifier returned for the transfer
    /// </summary>
    /// <value>String (max 35 chars), alphanumeric, read‑only; may be empty if not provided by the originating system</value>
    public string BillExternalSystemNumber1 { get; set; }

    /// <summary>
    /// Secondary external system identifier associated with the bill.
    /// </summary>
    /// <value>String returned by the external system; may be empty if not provided. Typically alphanumeric, up to 50 characters.</value>
    public string BillExternalSystemNumber2 { get; set; }

    /// <summary>
    /// The third external system identifier associated with the bill.
    /// </summary>
    /// <value>String, up to 50 alphanumeric characters; may be empty if not applicable. Used for integration with external accounting or ERP systems.</value>
    public string BillExternalSystemNumber3 { get; set; }

    /// <summary>
    /// The title or description of the bill linked to the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may include alphanumeric characters, spaces, and common punctuation; optional and present only when the transfer is associated with a bill.</value>
    public string BillTitle { get; set; }

    /// <summary>
    /// Identifier of the customer associated with the payment
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID that references an existing customer record in the system</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// External identifier of the customer on the opposite side of the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may be null if the transfer has no associated external customer; must match the format used by the partner system for customer IDs.</value>
    public string RelatedCustomerExternalId { get; set; }

    /// <summary>
    /// The textual description of the bill associated with the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may be empty if no bill is linked. Returned as‑is from the originating system and used for display or reconciliation.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer was created automatically (e.g., scheduled or recurring).
    /// </summary>
    /// <value>Boolean; true for automatic transfers, false for manual ones. Present only for transfers that support automation and is read‑only.</value>
    public bool IsAutomaticPayment { get; set; }

    /// <summary>
    /// PaymentInfo provides the full set of data required to create a new payment.
    /// </summary>
    /// <value>Must be a non‑null PaymentEntity containing a positive Amount, a supported Currency code, valid PayerId and PayeeId, and optionally a Description and DueDate. All fields are validated before processing.</value>
    public PaymentEntity PaymentInfo { get; set; }

    /// <summary>
    /// Merchant-controlled reconciliation flag. Mark a payment as reconciled in your own system, then filter listings with MarkResolvedOnly. Has no effect on payment processing.
    /// </summary>
    /// <value>true if this instance is mark resolved; otherwise, false.</value>
    public bool IsMarkResolved { get; set; }

    /// <summary>
    /// The current processing status of the transfer.
    /// </summary>
    /// <value>Read‑only enum (ProcessStatusEnum) indicating the latest state: Pending, InProgress, Completed, Failed, Cancelled, or Reversed. Returned only for transfers that have been processed.</value>
    public ProcessStatusEnum CurrentStatus { get; set; }

    /// <summary>
    /// Convenience fee amount charged for credit card payments.
    /// </summary>
    public decimal? ConvenientFeeCreditCard { get; set; }

    /// <summary>
    /// Convenience fee amount charged for direct account (EFT) payments.
    /// </summary>
    public decimal? ConvenientFeeDirectAccount { get; set; }

    /// <summary>
    /// Creation date of the payment (UTC).
    /// </summary>
    /// <value>The created date.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Descriptive name of the payment method used for the transfer.
    /// </summary>
    /// <value>Human‑readable string (e.g., "Bank Transfer", "Credit Card", "SEPA"); up to 100 characters; may be null if the method is not applicable.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// A short preview of the account involved in the transfer.
    /// </summary>
    /// <value>String up to 100 characters showing masked account number and optional holder name; may be empty if no account data is applicable.</value>
    public string AccountInformationPreview { get; set; }

    /// <summary>
    /// The payment method type employed for the transfer.
    /// </summary>
    /// <value>A value from the PaymentMethodTypeEnum (e.g., CARD, BANK_ACCOUNT, WALLET). It identifies the source/destination method, is always present in the response, and must match one of the defined enum members.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    }
}