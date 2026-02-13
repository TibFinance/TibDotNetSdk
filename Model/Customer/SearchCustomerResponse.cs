
using System;
using System.Collections.Generic;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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