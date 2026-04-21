
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
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The unique identifier of the supplier link to rename.
    /// </summary>
    /// <value></value>
    public Guid MerchantSupplierId { get; set; }

    /// <summary>
    /// The new display name for the supplier (max 150 characters).
    /// </summary>
    /// <value></value>
    public string SupplierName { get; set; }

    }
}