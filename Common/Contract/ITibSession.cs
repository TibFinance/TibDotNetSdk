
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common.Contract
{
    /// <summary>
    /// Represents the ITibSession interface.
    /// </summary>
    public interface ITibSession 
    {
        
    /// <summary>
    /// The session ID. Send it as SessionToken on the following calls.
    /// </summary>
    public Guid SessionId { get; set; }

    }
}