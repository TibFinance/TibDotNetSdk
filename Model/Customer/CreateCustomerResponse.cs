
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the CreateCustomerResponse model.
    /// </summary>
    public class CreateCustomerResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Whether the customer already existed and was returned instead of creating a new one.
    /// </summary>
    /// <value></value>
    public bool CustomerAlreadyExisted { get; set; }

    }
}