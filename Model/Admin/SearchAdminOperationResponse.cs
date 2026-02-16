
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchAdminOperationResponse model.
    /// </summary>
    public class SearchAdminOperationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all Transfers found
    /// </summary>
    /// <value></value>
    public List<AdminOperationModel> SearchResult { get; set; }

    }
}