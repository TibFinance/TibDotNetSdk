
using System;
using Tib.Api.Acp;

namespace Tib.Api.Acp.ACP120
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineEnd : BaseLastLine
    {
        
    /// <summary>
    /// Gets or sets the total amount collected.
    /// </summary>
    /// <value>The total amount collected.</value>
    public decimal TotalAmountCollected { get; set; }

    /// <summary>
    /// Gets or sets the number of transaction collected.
    /// </summary>
    /// <value>The number of transaction collected.</value>
    public int NumberOfTransactionCollected { get; set; }

    /// <summary>
    /// Gets or sets the total amount deposit.
    /// </summary>
    /// <value>The total amount deposit.</value>
    public decimal TotalAmountDeposit { get; set; }

    /// <summary>
    /// Gets or sets the number of transaction deposit.
    /// </summary>
    /// <value>The number of transaction deposit.</value>
    public int NumberOfTransactionDeposit { get; set; }

    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public int StartPosition { get; set; }

    }
}