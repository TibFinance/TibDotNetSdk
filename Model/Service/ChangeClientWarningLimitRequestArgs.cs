
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ChangeClientWarningLimitRequestArgs model.
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