
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateCustomerArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Provides access to detailed customer information necessary for transaction processing and account management.
    /// </summary>
    /// <value>Represents the customer entity within the system, encapsulating all relevant customer data.</value>
    public CustomerEntity Customer { get; set; }

    }
}