
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ChangePasswordRequest2Args model.
    /// </summary>
    public class ChangePasswordRequest2Args : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Unique identifier of the client initiating the session
    /// </summary>
    /// <value>Required Guid; must be a valid, registered client ID in the TIB Finance system</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The login identifier of the user initiating the session.
    /// </summary>
    /// <value>String, required, case‑sensitive, typically an email or account name; maximum length 256 characters; must correspond to a valid TIB Finance user.</value>
    public String Username { get; set; }

    }
}