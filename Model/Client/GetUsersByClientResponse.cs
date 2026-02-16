
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetUsersByClientResponse model.
    /// </summary>
    public class GetUsersByClientResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<ClientLoginModel> Users { get; set; }

    }
}