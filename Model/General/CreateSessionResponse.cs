
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the CreateSessionResponse model.
    /// </summary>
    public class CreateSessionResponse : ClientBaseResponse, ITibSession
    {
        
    /// <summary>
    /// Unique identifier for the newly created session
    /// </summary>
    /// <value>A 128‑bit GUID returned in the response; required for all subsequent authenticated API calls</value>
    public Guid SessionId { get; set; }

    }
}