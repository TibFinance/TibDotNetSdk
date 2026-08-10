
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the GetSuppliersResponse model.
    /// </summary>
    public class GetSuppliersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of suppliers as (Description, SupplierId) pairs: Description is the supplier's display name; SupplierId identifies the supplier in other supplier operations. Note that on the wire each pair serializes with tuple field names: Item1 = Description, Item2 = SupplierId.
    /// </summary>
    public List<object> Suppliers { get; set; }

    }
}