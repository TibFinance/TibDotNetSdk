
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ListServicesArgs model.
    /// </summary>
    public class ListServicesArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}