
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the GetCustomerResponse model.
    /// </summary>
    public class GetCustomerResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides access to detailed customer information necessary for transaction processing and account management.
    /// </summary>
    /// <value>Represents the customer entity within the system, encapsulating all relevant customer data.</value>
    public CustomerModel Customer { get; set; }

    }
}