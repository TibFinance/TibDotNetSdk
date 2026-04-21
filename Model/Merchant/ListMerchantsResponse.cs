
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the ListMerchantsResponse model.
    /// </summary>
    public class ListMerchantsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of merchant records matching the requested external identifier.
    /// </summary>
    /// <value>IEnumerable&lt;MerchantViewModel&gt; containing zero or more merchants; each element represents a distinct merchant linked to the supplied external ID. Order is not guaranteed.</value>
    public IEnumerable<MerchantViewModel> Merchants { get; set; }

    }
}