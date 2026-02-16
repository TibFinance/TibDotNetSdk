
using System;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetClientResponse model.
    /// </summary>
    public class GetClientResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Identifies the TIB client (account) using its unique GUID.
    /// </summary>
    /// <value>The Client ID is a GUID assigned by TIB during account opening; it is required for session creation and other calls.</value>
    public ClientModel Client { get; set; }

    }
}