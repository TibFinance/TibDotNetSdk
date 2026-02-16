
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchAdminServiceMerchantsResponse model.
    /// </summary>
    public class SearchAdminServiceMerchantsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all Transfers found
    /// </summary>
    /// <value></value>
    public List<AdminServiceMerchantModel> SearchResult { get; set; }

    }
}