
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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