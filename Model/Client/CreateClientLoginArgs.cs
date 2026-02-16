
using System;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the CreateClientLoginArgs model.
    /// </summary>
    public class CreateClientLoginArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The 'Password' property is a critical component in user authentication, safeguarding individualized user data.
    /// </summary>
    /// <value>This property stores a distinct string, representing the user's password, which is vital for user identification and data protection.</value>
    public string Password { get; set; }

    /// <summary>
    /// The user information to create
    /// </summary>
    /// <value>The client login.</value>
    public ClientLoginModel ClientLogin { get; set; }

    }
}