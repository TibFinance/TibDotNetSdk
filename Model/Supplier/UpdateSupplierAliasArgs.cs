
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
    /// The payer's merchant ID that owns the supplier link.
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