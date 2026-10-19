
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the GetCustomerArgs model.
    /// </summary>
    public class GetCustomerArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}