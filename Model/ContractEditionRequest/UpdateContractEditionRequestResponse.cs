
using System;
using Tib.Api.Model.ContractEditionRequest;
using Tib.Api.Common;

namespace Tib.Api.Model.ContractEditionRequest
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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