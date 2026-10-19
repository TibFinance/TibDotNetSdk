
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
    /// The payer's merchant ID that owns the supplier link.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The unique identifier of the supplier link to delete.
    /// </summary>
    public Guid MerchantSupplierId { get; set; }

    }
}