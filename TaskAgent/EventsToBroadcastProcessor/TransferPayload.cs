
using System;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferPayload 
    {
        
    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public string TransferId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public int? OperationKind { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal OriginalAmount { get; set; }

    /// <summary>
    /// Gets or sets the external reference identifier used to correlate this entity with an external system.
    /// </summary>
    /// <value>A string that uniquely identifies the entity in an external system.</value>
    public string ExternalReferenceId { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public string DueDate { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public string CreatedDate { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public string PaymentMethodId { get; set; }

    /// <summary>
    /// Provides a detailed description of the payment method for easy identification.
    /// </summary>
    /// <value>The 'PaymentMethodDescription' property stores a descriptive string that offers a comprehensive understanding of the specific payment method.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PaymentMethodPreview { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public string CustomerId { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Serves as a unique identifier for customers within an external system, enabling efficient data mapping and integration across various platforms.
    /// </summary>
    /// <value>This string parameter represents a distinct identifier assigned to a customer within an external system, thereby facilitating seamless synchronization of data and customer identification across different platforms.</value>
    public string CustomerExternalId { get; set; }

    /// <summary>
    /// Specifies the monetary amount of a bill to be created.
    /// </summary>
    /// <value>Decimal value representing the total amount due for the bill. Must be greater than zero.</value>
    public string BillAmount { get; set; }

    /// <summary>
    /// Specifies the currency of the bill. If null, the merchant’s default currency is applied.
    /// </summary>
    /// <value>CurrencyEnum value representing the bill’s currency.</value>
    public string BillCurrency { get; set; }

    /// <summary>
    /// Provides a textual description of the bill associated with a payment.
    /// </summary>
    /// <value>A free‑form string that describes the purpose or details of the bill. The value is stored and returned as‑is.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public string BillId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BillLanguage { get; set; }

    /// <summary>
    /// Represents the title of a bill associated with a payment.
    /// </summary>
    /// <value>This property holds the title of the bill. It is used to identify and describe the bill within the system.</value>
    public string BillTitle { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BillCreatedDate { get; set; }

    /// <summary>
    /// Represents the first external system bill reference associated with the TIB bill.
    /// </summary>
    /// <value>ExternalSystemBillNumber1 contains the bill number provided by the external system. It is a free‑form string limited to 150 characters and restricted to the allowed character set.</value>
    public string ExternalSystemBillNumber1 { get; set; }

    /// <summary>
    /// Reference number provided by an external system for the bill (field 2).
    /// </summary>
    /// <value>Contains the external system's bill identifier (up to 150 characters) using only permitted characters.</value>
    public string ExternalSystemBillNumber2 { get; set; }

    /// <summary>
    /// Identifies the bill number provided by an external system. This field allows TIB to map its internal bill to the originating system's reference.
    /// </summary>
    /// <value>The third external system bill number associated with the created bill.</value>
    public string ExternalSystemBillNumber3 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BillMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BillCustomerId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PayoutPayload Payout { get; set; }

    }
}