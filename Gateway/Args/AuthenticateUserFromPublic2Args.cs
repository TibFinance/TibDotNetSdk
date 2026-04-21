
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the AuthenticateUserFromPublic2Args model.
    /// </summary>
    public class AuthenticateUserFromPublic2Args : ClientCallBaseArgs, IPublicTokenObject
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid PublicTokenId { get; set; }

    }
}