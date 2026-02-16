
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
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
    public String Username { get; set; }

    }
}