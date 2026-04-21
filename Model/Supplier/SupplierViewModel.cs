
using System;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the SupplierViewModel model.
    /// </summary>
    public class SupplierViewModel 
    {
        
    /// <summary>
    /// Unique identifier of the merchant-supplier link.
    /// </summary>
    /// <value></value>
    public Guid MerchantSupplierId { get; set; }

    /// <summary>
    /// Unique identifier of the supplier's merchant account.
    /// </summary>
    /// <value></value>
    public Guid SupplierId { get; set; }

    /// <summary>
    /// Display name of the supplier.
    /// </summary>
    /// <value></value>
    public string SupplierName { get; set; }

    /// <summary>
    /// Email address of the supplier.
    /// </summary>
    /// <value></value>
    public string SupplierEmail { get; set; }

    /// <summary>
    /// Date and time the supplier link was created.
    /// </summary>
    /// <value></value>
    public DateTime Created { get; set; }

    }
}