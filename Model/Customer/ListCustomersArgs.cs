
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Represents the ListCustomersArgs model.
    /// </summary>
    public class ListCustomersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}