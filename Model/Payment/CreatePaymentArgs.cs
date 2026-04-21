
using System;
using Tib.Api.Model.Payment;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the CreatePaymentArgs model.
    /// </summary>
    public class CreatePaymentArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Indicates whether the payment’s customer should be automatically taken from the associated bill.
    /// </summary>
    /// <value>True copies the bill’s customer to the payment; false requires the caller to specify a customer. Only applicable when creating a payment from a bill and cannot be changed after creation.</value>
    public bool SetPaymentCustomerFromBill { get; set; }

    /// <summary>
    /// The email address of the customer initiating the payment.
    /// </summary>
    /// <value>Must be a valid RFC‑5322 email, max 254 characters; required for receipt delivery and notifications.</value>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// PaymentInfo provides the full set of data required to create a new payment.
    /// </summary>
    /// <value>Must be a non‑null PaymentEntity containing a positive Amount, a supported Currency code, valid PayerId and PayeeId, and optionally a Description and DueDate. All fields are validated before processing.</value>
    public PaymentEntity PaymentInfo { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// A client‑provided unique identifier for the payment request
    /// </summary>
    /// <value>Must be a non‑empty string, unique per merchant within the last 30 days, up to 64 alphanumeric characters (A‑Z, a‑z, 0‑9) and hyphens/underscores; used for idempotency and reconciliation.</value>
    public string ExternalReferenceId { get; set; }

    /// <summary>
    /// Indicates whether the payment should be split when its amount exceeds the remaining bill balance.
    /// </summary>
    /// <value>True allows the payment to be broken into multiple parts to cover the excess; false rejects the payment if it surpasses the remaining amount. Must be provided as a boolean.</value>
    public bool SafetyToBreakIfOverRemainingBillAmount { get; set; }

    /// <summary>
    /// Flags indicating which payment methods are authorized for the created payment
    /// </summary>
    /// <value>Bitmask of AuthorizedPaymentMethodFlags; combine multiple methods using OR. Must include at least one supported method; unsupported flags cause validation error.</value>
    public AutorizedPaymentMethodFlags? AutorizedPaymentMethod { get; set; }

    /// <summary>
    /// Indicates whether the platform must request the customer's consent before processing the payment.
    /// </summary>
    /// <value>Boolean; set to true to trigger a consent prompt (required for regulated or high‑value payments). Defaults to false if omitted.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// Controls whether a payment confirmation email is sent
    /// </summary>
    /// <value>Set to true to suppress the email (default false sends it). Ignored if email notifications are disabled or no recipient address is provided.</value>
    public bool DoNotSendEmail { get; set; }

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

    }
}