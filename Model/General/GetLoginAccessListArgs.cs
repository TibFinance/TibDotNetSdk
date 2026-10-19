
using System;
using Tib.Api.Common;
using Tib.Api.Model.General;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the GetLoginAccessListArgs model.
    /// </summary>
    public class GetLoginAccessListArgs : ClientCallBaseArgs, ILoginAccessList
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

    }
}