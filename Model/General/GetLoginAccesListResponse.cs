
using System;
using System.Collections.Generic;
using Tib.Api.Gateway.Entities;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the GetLoginAccesListResponse model.
    /// </summary>
    public class GetLoginAccesListResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the login relations.
    /// </summary>
    /// <value>The login relations.</value>
    public List<LoginRelationsEntity> LoginRelations { get; set; }

    }
}