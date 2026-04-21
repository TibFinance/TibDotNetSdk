
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
    /// Identifier for the authenticated user session
    /// </summary>
    /// <value>A non‑empty GUID issued at login; must correspond to an active session and be passed unchanged to authorize the CreatePayment request.</value>
    public Guid? SessionToken { get; set; }

    }
}