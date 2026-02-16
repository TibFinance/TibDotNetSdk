
using System;
using System.Collections.Generic;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the GetCustomersByExternalIdResponse model.
    /// </summary>
    public class GetCustomersByExternalIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents a collection of all customers currently using a specific service.
    /// </summary>
    /// <value>This property is an enumerable collection of 'CustomerModel' instances, each instance representing a unique customer.</value>
    public IEnumerable<CustomerModel> Customers { get; set; }

    }
}