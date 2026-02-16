
using System;
using System.Collections.Generic;
using Tib.Api.Model.General;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the CredentialBaseObject model.
    /// </summary>
    public class CredentialBaseObject 
    {
        
    /// <summary>
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
    public string Username { get; set; }

    /// <summary>
    /// The user's username2
    /// </summary>
    /// <value>The username2.</value>
    public string Username2 { get; set; }

    /// <summary>
    /// The 'Password' property is a critical component in user authentication, safeguarding individualized user data.
    /// </summary>
    /// <value>This property stores a distinct string, representing the user's password, which is vital for user identification and data protection.</value>
    public string Password { get; set; }

    /// <summary>
    /// Password 2
    /// </summary>
    /// <value>The password.</value>
    public string Password2 { get; set; }

    /// <summary>
    /// Gets or sets the questions.
    /// </summary>
    /// <value>The questions.</value>
    public List<QuestionAnswer> Questions { get; set; }

    /// <summary>
    /// Gets or sets the addresses.
    /// </summary>
    /// <value>The addresses.</value>
    public List<ProviderAddressEntity> Addresses { get; set; }

    }
}