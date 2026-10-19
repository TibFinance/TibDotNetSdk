
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierRecurringTransfersArgs model.
    /// </summary>
    public class ListSupplierRecurringTransfersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The payer's merchant ID. Recurring transfers where this merchant is the fee-payer will be returned.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}