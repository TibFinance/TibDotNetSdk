
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetSuppliersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<object> Suppliers { get; set; }

    }
}