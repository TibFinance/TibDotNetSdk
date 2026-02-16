
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the RefundMerchantArgs model.
    /// </summary>
    public class RefundMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsCommission { get; set; }

    }
}