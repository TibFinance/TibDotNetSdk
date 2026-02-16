
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
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}