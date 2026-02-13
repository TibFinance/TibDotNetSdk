
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class MonthlyStats 
    {
        
    /// <summary>
    /// Gets or sets the transaction category.
    /// </summary>
    /// <value>The transaction category.</value>
    public string TransactionCategory { get; set; }

    /// <summary>
    /// Gets or sets the year month.
    /// </summary>
    /// <value>The year month.</value>
    public string YearMonth { get; set; }

    /// <summary>
    /// Gets or sets the number of transactions.
    /// </summary>
    /// <value>The number of transactions.</value>
    public int NumberOfTransactions { get; set; }

    /// <summary>
    /// Gets or sets the amount of transactions.
    /// </summary>
    /// <value>The amount of transactions.</value>
    public decimal AmountOfTransactions { get; set; }

    }
}