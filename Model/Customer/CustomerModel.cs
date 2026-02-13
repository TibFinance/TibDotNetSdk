
using System;
using Tib.Api.Model.Customer;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CustomerModel : CustomerEntity
    {
        
    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid CustomerId { get; set; }

    }
}