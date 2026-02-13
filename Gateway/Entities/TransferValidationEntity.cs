
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferValidationEntity 
    {
        
    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the acount number.
    /// </summary>
    /// <value>The acount number.</value>
    public string AcountNumber { get; set; }

    /// <summary>
    /// Gets or sets the external reference number used to link this entity with an external system or business process.
    /// </summary>
    /// <value>The external reference number associated with the entity.</value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Gets or sets the tib authorization.
    /// </summary>
    /// <value>The tib authorization.</value>
    public TibAuthorizationStatus TibAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the tib authorization status string.
    /// </summary>
    /// <value>The tib authorization status string.</value>
    public string TibAuthorizationStatusStr { get; set; }

    /// <summary>
    /// Gets or sets the client authorization.
    /// </summary>
    /// <value>The client authorization.</value>
    public ClientAuthorizationStatus ClientAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the client authorization status string.
    /// </summary>
    /// <value>The client authorization status string.</value>
    public string ClientAuthorizationStatusStr { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Bill model representing a financial invoice in the TIB Finance system.
    /// </summary>
    /// <value>Contains the complete set of properties that describe a bill, such as BillId (Guid), Amount, Currency, Status, IssueDate, DueDate, and the associated CustomerId.</value>
    public string Bill { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public string TransferType { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public DateTime? DueDate { get; set; }

    }
}