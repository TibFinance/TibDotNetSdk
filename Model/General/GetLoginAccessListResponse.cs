
using System;
using System.Collections.Generic;
using Tib.Api.Gateway.Entities;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the GetLoginAccessListResponse model.
    /// </summary>
    public class GetLoginAccessListResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The user's accesses, one entry per access.
    /// </summary>
    public List<LoginRelationsEntity> LoginRelations { get; set; }

    }
}