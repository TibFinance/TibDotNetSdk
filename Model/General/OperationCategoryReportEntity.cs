
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the OperationCategoryReportEntity model.
    /// </summary>
    public class OperationCategoryReportEntity 
    {
        
    /// <summary>
    /// Gets or sets the type of the category.
    /// </summary>
    /// <value>The type of the category.</value>
    public OperationCategoryReportType CategoryType { get; set; }

    /// <summary>
    /// Gets or sets the number of transactions.
    /// </summary>
    /// <value>The number of transactions.</value>
    public int NumberOfTransactions { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> IncludedTransfers { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> IncludedOperations { get; set; }

    }
}