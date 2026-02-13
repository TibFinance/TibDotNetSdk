
using System;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifies the TIB client (account) using its unique GUID.
    /// </summary>
    /// <value>The Client ID is a GUID assigned by TIB during account opening; it is required for session creation and other calls.</value>
    public ClientEntity Client { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool KYCDone { get; set; }

    }
}