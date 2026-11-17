
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CreateCustomerV2Args model.
    /// </summary>
    public class CreateCustomerV2Args : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The service to create the customer in.
    /// </summary>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Required: the customer to create.
    /// </summary>
    public CustomerV2Model Customer { get; set; }

    }
}