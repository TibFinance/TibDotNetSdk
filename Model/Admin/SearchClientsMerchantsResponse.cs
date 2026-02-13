
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchClientsMerchantsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all clientsservicesmerchants matching the search
    /// </summary>
    /// <value></value>
    public List<SearchClientsMerchantModel> SearchResult { get; set; }

    }
}