
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the UpdateSupplierAliasArgs model.
    /// </summary>
    public class UpdateSupplierAliasArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The paying merchant that owns the supplier link. Required, except for a merchant-level login. For a merchant-level login, always that login's own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The unique identifier of the supplier link to rename.
    /// </summary>
    public Guid MerchantSupplierId { get; set; }

    /// <summary>
    /// The new display name for the supplier (max 150 characters).
    /// </summary>
    public string SupplierName { get; set; }

    }
}