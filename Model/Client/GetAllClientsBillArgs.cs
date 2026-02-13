
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetAllClientsBillArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the year.
    /// </summary>
    /// <value>The year.</value>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    /// <value>The month.</value>
    public int Month { get; set; }

    }
}