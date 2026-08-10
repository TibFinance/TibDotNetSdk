
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the CreateSupplierResponse model.
    /// </summary>
    public class CreateSupplierResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Unique identifier of the created or existing supplier's merchant account.
    /// </summary>
    public Guid SupplierId { get; set; }

    /// <summary>
    /// Display name of the supplier.
    /// </summary>
    public string SupplierName { get; set; }

    }
}