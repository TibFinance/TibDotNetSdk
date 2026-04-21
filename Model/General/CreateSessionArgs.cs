
using System;
using Tib.Api.Common;
using Tib.Api.Model.General;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the CreateSessionArgs model.
    /// </summary>
    public class CreateSessionArgs : ClientCallBaseArgs, ILoginAccessList
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
    public string Username { get; set; }

    /// <summary>
    /// The account password used to authenticate the session request
    /// </summary>
    /// <value>String, required, non‑empty; must meet the platform's password policy (minimum length, allowed characters) and is transmitted securely</value>
    public string Password { get; set; }

    }
}