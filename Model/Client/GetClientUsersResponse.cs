
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetClientUsersResponse model.
    /// </summary>
    public class GetClientUsersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of client users
    /// </summary>
    /// <value>The users.</value>
    public IEnumerable<ClientLoginModel> Users { get; set; }

    }
}