
using System;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BatchFileEventOperation 
    {
        
    /// <summary>
    /// Indicates that the operation completed successfully.
    /// </summary>
    /// <value>Numeric code representing a successful result (value = 1).</value>
    public bool Success { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? CreatedTransferId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the reference identifier used to uniquely identify a transaction, operation, or entity within the TIB Finance system.
    /// </summary>
    /// <value>A string containing the unique reference identifier. The identifier follows the GUID format supplied by TIB Finance.</value>
    public string ReferenceId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    }
}