
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
    /// List of suppliers matching the query criteria. Each entry contains a Description and SupplierId.
    /// </summary>
    /// <value></value>
    public List<object> Suppliers { get; set; }

    }
}