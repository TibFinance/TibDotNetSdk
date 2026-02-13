
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateSupplierResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid SupplierId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SupplierName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<MerchantViewModel> MatchingExistingMerchants { get; set; }

    }
}