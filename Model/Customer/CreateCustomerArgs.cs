
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CreateCustomerArgs model.
    /// </summary>
    public class CreateCustomerArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The customer data to be saved
    /// </summary>
    /// <value>A fully populated CustomerModel object; must not be null and must satisfy all validation rules (e.g., required fields such as Name, Email, and valid address). Optional fields may be omitted, but any provided values must conform to type constraints.</value>
    public CustomerEntity Customer { get; set; }

    }
}