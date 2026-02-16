
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the AuthenticateUserFromPublicArgs model.
    /// </summary>
    public class AuthenticateUserFromPublicArgs : AuthenticateUserArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String IpAddress { get; set; }

    }
}