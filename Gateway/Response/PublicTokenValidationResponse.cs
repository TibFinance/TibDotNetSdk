
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the PublicTokenValidationResponse model.
    /// </summary>
    public class PublicTokenValidationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsValid { get; set; }

    }
}