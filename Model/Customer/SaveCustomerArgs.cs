
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the SaveCustomerArgs model.
    /// </summary>
    public class SaveCustomerArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The customer data to be saved
    /// </summary>
    /// <value>A fully populated CustomerModel object; must not be null and must satisfy all validation rules (e.g., required fields such as Name, Email, and valid address). Optional fields may be omitted, but any provided values must conform to type constraints.</value>
    public CustomerModel Customer { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}