
using System;
using System.Collections.Generic;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionFeesAgregatedModel model.
    /// </summary>
    public class TransactionFeesAgregatedModel 
    {
        
    /// <summary>
    /// Gets or sets the fees by count.
    /// </summary>
    /// <value>The fees by count.</value>
    public List<TransactionFeesForCountModel> FeesByCount { get; set; }

    /// <summary>
    /// Gets or sets the total fee amount.
    /// </summary>
    /// <value>The total fee amount.</value>
    public decimal TotalFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the total number of payments.
    /// </summary>
    /// <value>The total number of payments.</value>
    public int TotalNumberOfPayments { get; set; }

    /// <summary>
    /// Gets or sets the total number of fees.
    /// </summary>
    /// <value>The total number of fees.</value>
    public int TotalNumberOfFees { get; set; }

    }
}