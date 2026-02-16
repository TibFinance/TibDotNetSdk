
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetRecuringTransfersResponse model.
    /// </summary>
    public class GetRecuringTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides access to a list of recurring transfer operations linked to the client's account, facilitating management and review of scheduled transfers.
    /// </summary>
    /// <value>This function queries the database to retrieve comprehensive details of all recurring transfers, including their current status, amounts, and scheduled dates.</value>
    public List<RecuringTransferModel> RecuringTransfers { get; set; }

    }
}