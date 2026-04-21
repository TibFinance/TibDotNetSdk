
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentEntity model.
    /// </summary>
    public class PaymentEntity 
    {
        
    /// <summary>
    /// Specifies the processing flow type for the payment being created
    /// </summary>
    /// <value>Must be one of the PaymentFlowEnum values (e.g., ONE_TIME, RECURRING, SCHEDULED). Required; case‑sensitive. Determines how the payment is handled and any subsequent actions.</value>
    public PaymentFlowEnum PaymentFlow { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Identifier of the customer associated with the payment
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID that references an existing customer record in the system</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// The date by which the created payment must be settled.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be a future date, not earlier than the current date, and cannot exceed the platform's maximum scheduling horizon.</value>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// Specifies how often the payment should be executed.
    /// </summary>
    /// <value>Accepts a TransferFrequencyEnum value (e.g., ONE_TIME, DAILY, WEEKLY, MONTHLY, YEARLY). Required for recurring payments; defaults to ONE_TIME if omitted.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// The monetary amount to be transferred in the transaction's currency.
    /// </summary>
    /// <value>Decimal, required, must be greater than 0, limited to two fractional digits, and must not exceed the payer's available balance or any configured transaction limits.</value>
    public decimal? PaymentAmount { get; set; }

    /// <summary>
    /// Identifier of a specific customer payment method to force for this payment
    /// </summary>
    /// <value>Guid of an existing payment method belonging to the customer; overrides the default selection. Must be a valid GUID and correspond to a payment method the customer can use. If omitted, the platform selects the appropriate method automatically.</value>
    public Guid? ForcedCustomerPaymentMethodId { get; set; }

    /// <summary>
    /// Identifier of the payment group to which the payment belongs
    /// </summary>
    /// <value>String, required, non‑empty, max 36 characters, must be a valid UUID/GUID if the system uses GUIDs</value>
    public string GroupId { get; set; }

    /// <summary>
    /// A client‑provided identifier that uniquely references the payment in external systems.
    /// </summary>
    /// <value>String, up to 35 alphanumeric characters; must be unique per merchant per day; used for reconciliation and audit trails.</value>
    public string ExternalReferenceIdentification { get; set; }

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
    /// Specifies whether the new payment should be created as a deleted (soft‑deleted) record.
    /// </summary>
    /// <value>Accepts true or false; typically must be false on creation—setting true may be ignored or rejected as the payment is not yet persisted.</value>
    public bool IsDeleted { get; set; }

    }
}