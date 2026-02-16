
using System;
using System.Collections.Generic;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the ListSubClientsResponse model.
    /// </summary>
    public class ListSubClientsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the collection of services associated with a client.
    /// </summary>
    /// <value>This property represents a collection of services linked to a client account within the TIB Finance system. It is used to manage and access various service contracts that a client may have with TIB Finance.</value>
    public IEnumerable<ServiceModel> Services { get; set; }

    }
}