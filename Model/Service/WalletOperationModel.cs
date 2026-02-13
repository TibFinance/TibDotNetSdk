
using System;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class WalletOperationModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime Date { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsWithdrawn { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    }
}