
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the CashBackStats model.
    /// </summary>
    public class CashBackStats 
    {
        
    /// <summary>
    /// Gets or sets the date.
    /// </summary>
    /// <value>The date.</value>
    public string Date { get; set; }

    /// <summary>
    /// Gets or sets the count.
    /// </summary>
    /// <value>The count.</value>
    public int Count { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    }
}