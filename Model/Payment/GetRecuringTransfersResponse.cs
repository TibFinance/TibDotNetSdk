
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
    /// A list of scheduled recurring transfer objects returned by GetRecuringTransfers.
    /// </summary>
    /// <value>Each item is a RecuringTransferModel containing transfer ID, amount, currency, frequency, start/end dates, next execution date, status, and optional description. The list may be empty; maximum size is defined by the API pagination limits. Read‑only field.</value>
    public List<RecuringTransferModel> RecuringTransfers { get; set; }

    }
}