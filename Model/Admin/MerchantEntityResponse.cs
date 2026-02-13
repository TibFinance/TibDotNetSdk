
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class MerchantEntityResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides detailed information about all merchants associated with a client's account. This is crucial for managing merchant-specific data within the API.
    /// </summary>
    /// <value>This property contains a collection of MerchantViewModel objects, each representing a merchant associated with the client's account.</value>
    public List<MerchantEntity> Merchants { get; set; }

    }
}