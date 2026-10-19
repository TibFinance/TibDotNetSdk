
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the MerchantIdName model.
    /// </summary>
    public class MerchantIdName 
    {
        
    /// <summary>
    /// The merchant id
    /// </summary>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    }
}