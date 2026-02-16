
using System;
using System.Collections.Generic;
using Tib.Api.Model.ContractEditionRequest;
using Tib.Api.Common;

namespace Tib.Api.Model.ContractEditionRequest
{
    /// <summary>
    /// Represents the GetContractEditionRequestsResponse model.
    /// </summary>
    public class GetContractEditionRequestsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<ContractEditionRequestModel> ContractEdditionRequests { get; set; }

    }
}