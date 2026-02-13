
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RecuringTransferModel 
    {
        
    /// <summary>
    /// Indicates the next scheduled date for a recurring transfer operation associated with the client's account.
    /// </summary>
    /// <value>This property retrieves the date and time of the next occurrence of a recurring transfer, allowing clients to manage and anticipate their scheduled transactions.</value>
    public DateTime NextRecuringDate { get; set; }

    /// <summary>
    /// Identifies a specific recurring transfer operation associated with a client's account.
    /// </summary>
    /// <value>This GUID uniquely represents a recurring transfer, allowing for precise management and retrieval of transfer details.</value>
    public Guid RecuringTransferId { get; set; }

    /// <summary>
    /// Defines the frequency of recurring transfer operations within the client's account. This enumeration is crucial for setting up and managing scheduled transfers.
    /// </summary>
    /// <value>The RecuringMode enumeration specifies the intervals at which recurring transfers occur. It helps automate the process of transferring funds at regular intervals, such as daily, weekly, or monthly.</value>
    public TransferFrequencyEnum RecuringMode { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Identifies the payment method associated with a specific transaction or operation.
    /// </summary>
    /// <value>This property stores the unique identifier for a payment method, allowing the system to link transactions to the correct financial account.</value>
    public Guid? RelatedPaymentMethodId { get; set; }

    /// <summary>
    /// Gets or sets the reference date used for scheduling recurring transfers.
    /// </summary>
    /// <value>The reference date defines the base point from which recurrence intervals are calculated. It must be a valid UTC DateTime.</value>
    public DateTime RecuringRefDate { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
    public Guid RelatedMerchantId { get; set; }

    /// <summary>
    /// Gets or sets the name of the merchant related to the current operation.
    /// </summary>
    /// <value>The merchant name is stored as a UTF-8 string and can be used for display or for filtering transactions by merchant.</value>
    public string RelatedMerchantName { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the title of the transfer.
    /// </summary>
    /// <value>The title is a short, human‑readable string that identifies the purpose of the transfer.</value>
    public string TrasnferTitle { get; set; }

    /// <summary>
    /// Provides a textual description of a transfer operation.
    /// </summary>
    /// <value>Contains a human‑readable summary that explains the purpose, parties, and details of the transfer.</value>
    public string TrasnferDescription { get; set; }

    /// <summary>
    /// External system identifier for a transfer.
    /// </summary>
    /// <value>Holds the identifier assigned by an external system to correlate the transfer record.</value>
    public string TrasnferExternalSystemNumber { get; set; }

    }
}