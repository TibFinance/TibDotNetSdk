
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListClientsWithRequestCountResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all TIB client
    /// </summary>
    /// <value>The clients.</value>
    public IEnumerable<ClientModelWithRequestCount> Clients { get; set; }

    }
}