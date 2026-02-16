
using System;
using Tib.Api.Common;
using Tib.Api.Model.General;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the LoginArgs model.
    /// </summary>
    public class LoginArgs : ClientCallBaseArgs, ILogin
    {
        
    /// <summary>
    /// Retrieves or assigns the identifier for user login relations.
    /// </summary>
    /// <value>Represents the unique identifier associated with user login relations.</value>
    public Guid LoginsUserRelationsId { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

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

    }
}