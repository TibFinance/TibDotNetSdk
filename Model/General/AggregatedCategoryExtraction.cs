
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the AggregatedCategoryExtraction model.
    /// </summary>
    public class AggregatedCategoryExtraction 
    {
        
    /// <summary>
    /// Gets or sets the data summary aggregation category.
    /// </summary>
    /// <value>The data summary aggregation category.</value>
    public DataSummaryAggregationCategoryEnum DataSummaryAggregationCategory { get; set; }

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