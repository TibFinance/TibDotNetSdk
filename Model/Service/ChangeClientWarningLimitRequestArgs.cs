
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ChangeClientWarningLimitRequestArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the client limits.
    /// </summary>
    /// <value>The client limits.</value>
    public PendingChangeClientLimits ClientLimits { get; set; }

    }
}