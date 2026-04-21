
using System;
using System.Collections.Generic;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the ListCustomersResponse model.
    /// </summary>
    public class ListCustomersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of customers that match the requested external identifier.
    /// </summary>
    /// <value>IEnumerable&lt;CustomerModel&gt; containing zero or more CustomerModel objects; each entry represents a distinct customer with the given external ID. The list may be empty if no matches are found and order is not guaranteed.</value>
    public IEnumerable<CustomerModel> Customers { get; set; }

    }
}