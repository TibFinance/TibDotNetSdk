
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the BaseProcessDropInArgs model.
    /// </summary>
    public class BaseProcessDropInArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsPPAAuthorized { get; set; }

    }
}