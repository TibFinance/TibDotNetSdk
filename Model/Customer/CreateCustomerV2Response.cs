
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CreateCustomerV2Response model.
    /// </summary>
    public class CreateCustomerV2Response : ClientBaseResponse
    {
        
    /// <summary>
    /// The CustomerId of the new customer.
    /// </summary>
    public Guid CustomerId { get; set; }

    }
}