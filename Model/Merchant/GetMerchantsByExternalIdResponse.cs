
using System;
using System.Collections.Generic;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetMerchantsByExternalIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides detailed information about all merchants associated with a client's account. This is crucial for managing merchant-specific data within the API.
    /// </summary>
    /// <value>This property contains a collection of MerchantViewModel objects, each representing a merchant associated with the client's account.</value>
    public IEnumerable<MerchantViewModel> Merchants { get; set; }

    }
}