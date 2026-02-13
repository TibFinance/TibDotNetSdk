
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common.Contract
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public interface ITibSessionArgs 
    {
        
    /// <summary>
    /// Handles the acquisition or assignment of a unique session token, acting as a distinct identifier for the user's session.
    /// </summary>
    /// <value>This symbolizes a unique token that identifies a user's session, ensuring secure and personalized system access.</value>
    public Guid? SessionToken { get; set; }

    }
}