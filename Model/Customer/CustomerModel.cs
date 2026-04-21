
using System;
using Tib.Api.Model.Customer;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CustomerModel model.
    /// </summary>
    public class CustomerModel : CustomerEntity
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    }
}