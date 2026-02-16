
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
    /// The 'Password' property is a critical component in user authentication, safeguarding individualized user data.
    /// </summary>
    /// <value>This property stores a distinct string, representing the user's password, which is vital for user identification and data protection.</value>
    public string Password { get; set; }

    }
}