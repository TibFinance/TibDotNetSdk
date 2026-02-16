
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the PublicTokenValidationArgs model.
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