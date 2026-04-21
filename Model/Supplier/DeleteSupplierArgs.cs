
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
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The unique identifier of the supplier link to delete.
    /// </summary>
    /// <value></value>
    public Guid MerchantSupplierId { get; set; }

    }
}