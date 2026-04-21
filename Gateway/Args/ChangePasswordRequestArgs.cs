
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ChangePasswordRequestArgs model.
    /// </summary>
    public class ChangePasswordRequestArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// The login identifier of the user initiating the session.
    /// </summary>
    /// <value>String, required, case‑sensitive, typically an email or account name; maximum length 256 characters; must correspond to a valid TIB Finance user.</value>
    public string Username { get; set; }

    /// <summary>
    /// Gets and set the type of the routing.
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType RoutingType { get; set; }

    }
}