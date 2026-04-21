
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ChangeUserPasswordArgs model.
    /// </summary>
    public class ChangeUserPasswordArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// The account password used to authenticate the session request
    /// </summary>
    /// <value>String, required, non‑empty; must meet the platform's password policy (minimum length, allowed characters) and is transmitted securely</value>
    public string Password { get; set; }

    }
}