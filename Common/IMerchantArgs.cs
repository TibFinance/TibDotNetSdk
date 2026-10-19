
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the IMerchantArgs interface.
    /// </summary>
    public interface IMerchantArgs 
    {
        
    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}