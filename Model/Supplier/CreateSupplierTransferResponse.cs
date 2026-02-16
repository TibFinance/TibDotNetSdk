
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the CreateSupplierTransferResponse model.
    /// </summary>
    public class CreateSupplierTransferResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<MerchantViewModel> MatchingExistingMerchants { get; set; }

    }
}