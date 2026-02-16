
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the SearchCustomersResponse model.
    /// </summary>
    public class SearchCustomersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of all customers found
    /// </summary>
    /// <value></value>
    public List<SearchCustomerModel> SearchResult { get; set; }

    }
}