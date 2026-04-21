
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierRecurringTransfersResponse model.
    /// </summary>
    public class ListSupplierRecurringTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of active recurring supplier transfer configurations where the caller is the fee-payer.
    /// </summary>
    /// <value></value>
    public List<RecuringTransferModel> RecurringTransfers { get; set; }

    }
}