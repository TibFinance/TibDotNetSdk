
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the ListClientsWithRequestCountResponse model.
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