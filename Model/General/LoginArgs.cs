
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
    /// The client ID the user signs in with, as for CreateSession.
    /// </summary>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The user's username. It is not case-sensitive.
    /// </summary>
    public string Username { get; set; }

    /// <summary>
    /// The user's password.
    /// </summary>
    public string Password { get; set; }

    /// <summary>
    /// The access to open: a LoginsUserRelationsId returned by GetLoginAccessList for the same user.
    /// </summary>
    public Guid LoginsUserRelationsId { get; set; }

    }
}