
using System;

namespace Tib.Api.Model.AccountCheck
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CheckResultModel 
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether [account found].
    /// </summary>
    /// <value><c>true<c> if [account found]; otherwise, <c>false<c>.</value>
    public bool AccountFound { get; set; }

    /// <summary>
    /// Specifies the starting date for filtering payment due dates.
    /// </summary>
    /// <value>Indicates the initial date from which payments are considered.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Specifies the payment due date.
    /// </summary>
    /// <value>Indicates the end date for payment processing.</value>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Gets or sets the fail count.
    /// </summary>
    /// <value>The fail count.</value>
    public int FailCount { get; set; }

    }
}