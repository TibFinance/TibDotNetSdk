
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.ContractEditionRequest
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class UpdateContractEditionRequestArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int ContractEditionRequestId { get; set; }

    }
}