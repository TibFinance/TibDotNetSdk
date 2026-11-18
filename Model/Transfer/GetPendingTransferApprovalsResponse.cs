
using System;
using System.Collections.Generic;
using Tib.Api.Model.Transfer;
using Tib.Api.Common;

namespace Tib.Api.Model.Transfer
{
    /// <summary>
    /// Represents the GetPendingTransferApprovalsResponse model.
    /// </summary>
    public class GetPendingTransferApprovalsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The transfers that are waiting for an approval, the newest first.
    /// </summary>
    public List<PendingTransferDto> PendingTransfers { get; set; }

    }
}