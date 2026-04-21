
using System;
using System.Collections.Generic;
using Tib.Api.Model.Supplier;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSuppliersResponse model.
    /// </summary>
    public class ListSuppliersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of suppliers associated with the authenticated client.
    /// </summary>
    /// <value></value>
    public List<SupplierViewModel> Suppliers { get; set; }

    }
}