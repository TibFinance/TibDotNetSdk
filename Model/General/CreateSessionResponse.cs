
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
    /// The session ID. Send it as SessionToken on the following calls.
    /// </summary>
    public Guid SessionId { get; set; }

    }
}