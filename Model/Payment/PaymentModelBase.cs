
using System;
using Tib.Api.Model.Payment;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PaymentModelBase 
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Identifier utilized by an external system for bill tracking.
    /// </summary>
    /// <value>Represents the primary external system number associated with a bill.</value>
    public string BillExternalSystemNumber1 { get; set; }

    /// <summary>
    /// Represents the identifier used by an external system for billing purposes.
    /// </summary>
    /// <value>This property holds the secondary external system number associated with a bill. It is used to link billing information with external systems.</value>
    public string BillExternalSystemNumber2 { get; set; }

    /// <summary>
    /// Identifier utilized by an external system for bill tracking.
    /// </summary>
    /// <value>Represents the third external system number associated with a bill, used for integration and tracking purposes.</value>
    public string BillExternalSystemNumber3 { get; set; }

    /// <summary>
    /// Represents the title of a bill associated with a payment.
    /// </summary>
    /// <value>This property holds the title of the bill. It is used to identify and describe the bill within the system.</value>
    public string BillTitle { get; set; }

    /// <summary>
    /// Identifies the customer linked to this payment, when a customer relationship exists.
    /// </summary>
    /// <value>The unique GUID that references the associated customer record.</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// Identifies the external customer associated with the payment, when applicable.
    /// </summary>
    /// <value>A string containing the external identifier of the related customer. The identifier is supplied by the merchant’s external system and is used only for reference; it does not replace the internal TIB customer GUID.</value>
    public string RelatedCustomerExternalId { get; set; }

    /// <summary>
    /// Provides a textual description of the bill associated with a payment.
    /// </summary>
    /// <value>A free‑form string that describes the purpose or details of the bill. The value is stored and returned as‑is.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Indicates whether the payment is processed automatically without user intervention.
    /// </summary>
    /// <value>Returns true when the payment is configured for automatic processing; otherwise returns false.</value>
    public bool IsAutomaticPayment { get; set; }

    /// <summary>
    /// Contains metadata for a payment operation.
    /// </summary>
    /// <value>Represents the core attributes of a payment, such as identifiers, amount, currency, status, and timestamps.</value>
    public PaymentEntity PaymentInfo { get; set; }

    /// <summary>
    /// Flag used to indicate that the payment is resolved in the third‑party system. It is employed solely for filtering payment lists.
    /// </summary>
    /// <value>True if the payment is marked as resolved; otherwise, false.</value>
    public bool IsMarkResolved { get; set; }

    /// <summary>
    /// Current processing state of a transaction or operation.
    /// </summary>
    /// <value>Indicates the current status of the process using the ProcessStatusEnum values.</value>
    public ProcessStatusEnum CurrentStatus { get; set; }

    /// <summary>
    /// Gets or sets the fee applied to credit‑card transactions when the convenient fee option is used.
    /// </summary>
    /// <value>A decimal value representing the credit‑card convenient fee expressed in the transaction currency.</value>
    public decimal? ConvenientFeeCreditCard { get; set; }

    /// <summary>
    /// Gets or sets the fee amount that is directly applied to the merchant's account for convenience services.
    /// </summary>
    /// <value>Decimal value representing the direct convenience fee charged to the account. The fee is expressed in the merchant's configured currency.</value>
    public decimal? ConvenientFeeDirectAccount { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Provides a detailed description of the payment method for easy identification.
    /// </summary>
    /// <value>The 'PaymentMethodDescription' property stores a descriptive string that offers a comprehensive understanding of the specific payment method.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// Provides a read‑only preview of the merchant’s bank account information.
    /// </summary>
    /// <value>Contains a masked representation of the account number and related bank identifiers, suitable for display purposes only.</value>
    public string AccountInformationPreview { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    }
}