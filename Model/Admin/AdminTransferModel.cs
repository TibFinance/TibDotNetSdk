
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AdminTransferModel 
    {
        
    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? RefId { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
    public Guid RelatedMerchantId { get; set; }

    /// <summary>
    /// Identifies the customer linked to this payment, when a customer relationship exists.
    /// </summary>
    /// <value>The unique GUID that references the associated customer record.</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid? PaymentMethodId { get; set; }

    /// <summary>
    /// Current processing state of a transaction or operation.
    /// </summary>
    /// <value>Indicates the current status of the process using the ProcessStatusEnum values.</value>
    public ProcessStatusEnum CurrentStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PaymentFlowEnum? PaymentFlowType { get; set; }

    /// <summary>
    /// Identifies the customer payment method that is mandatory when the payment flow operates in forced mode.
    /// </summary>
    /// <value>Guid of the forced customer payment method.</value>
    public Guid? ForcedCustomerPaymentMethodId { get; set; }

    /// <summary>
    /// Indicates whether the payment is processed automatically without user intervention.
    /// </summary>
    /// <value>Returns true when the payment is configured for automatic processing; otherwise returns false.</value>
    public bool? IsAutomaticPayment { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the transfer must be completed.
    /// </summary>
    /// <value>The due date of the transfer represented as a UTC DateTime.</value>
    public DateTime? TransferDueDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal TransferAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public LanguageEnum OverrideLanguage { get; set; }

    /// <summary>
    /// Flag used to indicate that the payment is resolved in the third‑party system. It is employed solely for filtering payment lists.
    /// </summary>
    /// <value>True if the payment is marked as resolved; otherwise, false.</value>
    public bool? IsMarkResolved { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal? ConvenientFeesForCreditCard { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal? ConvenientFeesForDirectAccount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsOperationCreated { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the external reference number used to link this entity with an external system or business process.
    /// </summary>
    /// <value>The external reference number associated with the entity.</value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransferTypeRef { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsDeleted { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime? CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public CurrencyEnum? OverrideCurrency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int LimitationStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int ClientAuthorizationStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? ClientAuthorizedBy { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public TibAuthorizationStatus TIBAuthorizationStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? TIBAuthorizedBy { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? TIBAuthorizationDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? ClientAuthorizationDate { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? AuthorizedPaymentMethodType { get; set; }

    /// <summary>
    /// Identifies a specific recurring transfer operation associated with a client's account.
    /// </summary>
    /// <value>This GUID uniquely represents a recurring transfer, allowing for precise management and retrieval of transfer details.</value>
    public Guid? RecuringTransferId { get; set; }

    /// <summary>
    /// Represents a brief description used in statements to identify or clarify the transaction.
    /// </summary>
    /// <value>This string provides a concise description for transactions, aiding in the identification and clarification of statement entries.</value>
    public string StatementDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsArchived { get; set; }

    /// <summary>
    /// Indicates if the system must request the customer's consent prior to executing the payment.
    /// </summary>
    /// <value>Set to true to trigger a consent request; false skips the consent step.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// Gets or sets the title that identifies the object in a human‑readable way.
    /// </summary>
    /// <value>A short, descriptive string displayed in user interfaces and reports.</value>
    public string Title { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Decription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ExternalSystemNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TIBAuthorizationStatusValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string TransferTypeValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CurrentStatusValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PaymentFlowTypeValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OverrideLanguageValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OverrideCurrencyValue { get; set; }

    }
}