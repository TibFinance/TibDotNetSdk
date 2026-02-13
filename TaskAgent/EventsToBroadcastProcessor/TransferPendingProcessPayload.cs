
using System;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferPendingProcessPayload : BaseEventPayload
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Retrieves or assigns the service's name.
    /// </summary>
    /// <value>This property holds the name of the service, which is crucial for identifying and managing the service within the TIB Finance system.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Identifier of the merchant in an external system
    /// </summary>
    /// <value>A string that uniquely identifies the merchant within an external system.</value>
    public string MerchantExternalSystemId { get; set; }

    /// <summary>
    /// Identifier of the merchant's external system group.
    /// </summary>
    /// <value>A string that uniquely identifies the external system group associated with the merchant. It is required when linking the merchant to third‑party platforms.</value>
    public string MerchantExternalSystemGroupId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Indicates whether the payment is processed automatically without user intervention.
    /// </summary>
    /// <value>Returns true when the payment is configured for automatic processing; otherwise returns false.</value>
    public bool IsAutomaticPayment { get; set; }

    /// <summary>
    /// Contains metadata for a payment operation.
    /// </summary>
    /// <value>Represents the core attributes of a payment, such as identifiers, amount, currency, status, and timestamps.</value>
    public TransferPayload PaymentInfo { get; set; }

    /// <summary>
    /// Flag used to indicate that the payment is resolved in the third‑party system. It is employed solely for filtering payment lists.
    /// </summary>
    /// <value>True if the payment is marked as resolved; otherwise, false.</value>
    public bool IsMarkResolved { get; set; }

    /// <summary>
    /// Current processing state of a transaction or operation.
    /// </summary>
    /// <value>Indicates the current status of the process using the ProcessStatusEnum values.</value>
    public int CurrentStatus { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public string CreatedDate { get; set; }

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
    public int PaymentMethodType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal PreCalculatedFees { get; set; }

    }
}