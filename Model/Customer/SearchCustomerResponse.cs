
using System;
using System.Collections.Generic;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the SearchCustomerResponse model.
    /// </summary>
    public class SearchCustomerResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The customer informations
    /// </summary>
    /// <value>The customer.</value>
    public List<SearchCustomerResultModel> SearchResult { get; set; }

    }
}