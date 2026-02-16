
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetConsolidationInternalReportArgs model.
    /// </summary>
    public class GetConsolidationInternalReportArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    /// <value>The month.</value>
    public int Month { get; set; }

    /// <summary>
    /// Gets or sets the year.
    /// </summary>
    /// <value>The year.</value>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [split group identifier].
    /// </summary>
    /// <value><c>true<c> if [split group identifier]; otherwise, <c>false<c>.</value>
    public bool SplitGroupId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [use collection].
    /// </summary>
    /// <value><c>true<c> if [use collection]; otherwise, <c>false<c>.</value>
    public bool UseCollection { get; set; }

    }
}