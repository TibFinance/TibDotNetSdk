
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
    /// List of non-deleted recurring supplier transfer configurations — rows where the calling merchant is the fee-payer for ListSupplierRecurringTransfers, or where any merchant of the requested service is the fee-payer for ListSupplierRecurringTransfersByService.
    /// </summary>
    public List<RecuringTransferModel> RecurringTransfers { get; set; }

    }
}