
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchCompanyArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Gets and sets the searching text
    /// </summary>
    /// <value></value>
    public string text { get; set; }

    }
}