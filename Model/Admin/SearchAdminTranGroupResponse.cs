
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchAdminTranGroupResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all Transfers found
    /// </summary>
    /// <value></value>
    public List<AdminTranGroupModel> SearchResult { get; set; }

    }
}