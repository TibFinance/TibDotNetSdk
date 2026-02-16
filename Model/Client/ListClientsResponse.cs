
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the ListClientsResponse model.
    /// </summary>
    public class ListClientsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all TIB client
    /// </summary>
    /// <value>The clients.</value>
    public IEnumerable<ClientModel> Clients { get; set; }

    }
}