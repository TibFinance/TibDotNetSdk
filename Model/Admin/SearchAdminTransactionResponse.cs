
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchAdminTransactionResponse model.
    /// </summary>
    public class SearchAdminTransactionResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all Transfers found
    /// </summary>
    /// <value></value>
    public List<AdminTransactionModel> SearchResult { get; set; }

    }
}