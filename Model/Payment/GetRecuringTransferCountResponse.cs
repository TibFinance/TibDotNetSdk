
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetRecuringTransferCountResponse model.
    /// </summary>
    public class GetRecuringTransferCountResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int RecuringTransfersCount { get; set; }

    }
}