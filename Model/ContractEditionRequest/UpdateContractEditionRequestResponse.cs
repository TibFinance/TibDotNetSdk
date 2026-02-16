
using System;
using Tib.Api.Model.ContractEditionRequest;
using Tib.Api.Common;

namespace Tib.Api.Model.ContractEditionRequest
{
    /// <summary>
    /// Represents the UpdateContractEditionRequestResponse model.
    /// </summary>
    public class UpdateContractEditionRequestResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ContractEditionRequestModel ContractEditionRequest { get; set; }

    }
}