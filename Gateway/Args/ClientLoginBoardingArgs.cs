
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ClientLoginBoardingArgs model.
    /// </summary>
    public class ClientLoginBoardingArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
    public string Username { get; set; }

    /// <summary>
    /// The 'Password' property is a critical component in user authentication, safeguarding individualized user data.
    /// </summary>
    /// <value>This property stores a distinct string, representing the user's password, which is vital for user identification and data protection.</value>
    public string Password { get; set; }

    /// <summary>
    /// Gets and set the type of the routing.
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType RoutingType { get; set; }

    }
}