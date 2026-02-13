
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SaveContractEditionRequestArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Gets and sets the request content for contract edition.
    /// </summary>
    /// <value></value>
    public string RequestContent { get; set; }

    }
}