
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PublicTokenValidationArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType TokenType { get; set; }

    }
}