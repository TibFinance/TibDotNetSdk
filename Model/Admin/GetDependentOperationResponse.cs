
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the GetDependentOperationResponse model.
    /// </summary>
    public class GetDependentOperationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<DependentOperationModel> OperationIds { get; set; }

    }
}