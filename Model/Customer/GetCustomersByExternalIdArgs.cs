
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the GetCustomersByExternalIdArgs model.
    /// </summary>
    public class GetCustomersByExternalIdArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The external identifier of the customer to retrieve.
    /// </summary>
    /// <value>String (max 255 chars), required, case‑sensitive, must match the ID used in the external system; URL‑encode special characters.</value>
    public string ExternalCustomerId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}