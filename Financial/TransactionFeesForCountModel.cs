
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionFeesForCountModel model.
    /// </summary>
    public class TransactionFeesForCountModel 
    {
        
    /// <summary>
    /// Gets or sets the fee count.
    /// </summary>
    /// <value>The fee count.</value>
    public int FeeCount { get; set; }

    /// <summary>
    /// Gets or sets the fee amount.
    /// </summary>
    /// <value>The fee amount.</value>
    public decimal FeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the number of payment.
    /// </summary>
    /// <value>The number of payment.</value>
    public int NumberOfPayment { get; set; }

    /// <summary>
    /// Gets or sets the number of fees.
    /// </summary>
    /// <value>The number of fees.</value>
    public int NumberOfFees { get; set; }

    }
}