
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LogOffSessionResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether [logg off success].
    /// </summary>
    /// <value><c>true<c> if [logg off success]; otherwise, <c>false<c>.</value>
    public bool LoggOffSuccess { get; set; }

    }
}