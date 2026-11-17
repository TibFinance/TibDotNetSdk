
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
    /// The paying merchant: the recurring transfers where this merchant is the fee-payer are returned. Required, except for a merchant-level login. For a merchant-level login, always that login's own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}