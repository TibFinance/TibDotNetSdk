
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSuppliersArgs model.
    /// </summary>
    public class ListSuppliersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The merchant whose suppliers are listed. Required, except for a merchant-level login. For a merchant-level login, always that login's own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}