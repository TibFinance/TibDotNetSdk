
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the DeleteSupplierArgs model.
    /// </summary>
    public class DeleteSupplierArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The paying merchant that owns the supplier link. Required, except for a merchant-level login. For a merchant-level login, always that login's own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The unique identifier of the supplier link to delete.
    /// </summary>
    public Guid MerchantSupplierId { get; set; }

    }
}