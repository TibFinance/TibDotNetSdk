
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the BaseAuthenticatedCryptedArgs model.
    /// </summary>
    public class BaseAuthenticatedCryptedArgs : ClientCallBaseArgs, IAuthenticatedSessionArgs
    {
        
    /// <summary>
    /// Handles the acquisition or assignment of a unique session token, acting as a distinct identifier for the user's session.
    /// </summary>
    /// <value>This symbolizes a unique token that identifies a user's session, ensuring secure and personalized system access.</value>
    public Guid? SessionToken { get; set; }

    }
}