
using System;
using System.Collections.Generic;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransactionEventPayload : BaseEventPayload
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Target { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Direction { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Step { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DescriptionCode { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public string Amount { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public string MerchantId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantAccountPreview { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantExternalId { get; set; }

    /// <summary>
    /// Contains a free‑text description of the merchant, which is stored in the TIB Finance system and displayed in merchant records.
    /// </summary>
    /// <value>A UTF‑8 encoded string that describes the merchant. The description is optional but recommended for identification purposes.</value>
    public string MerchantDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<TransferPayload> TransferPayload { get; set; }

    }
}