
using System;

namespace Tib.Api.Model.AccountCheck
{
    /// <summary>
    /// Represents the CheckResultDetailModel model.
    /// </summary>
    public class CheckResultDetailModel 
    {
        
    /// <summary>
    /// Gets or sets the event date.
    /// </summary>
    /// <value>The event date.</value>
    public DateTime? EventDate { get; set; }

    /// <summary>
    /// Gets or sets the transaciton amount.
    /// </summary>
    /// <value>The transaciton amount.</value>
    public decimal TransacitonAmount { get; set; }

    }
}