
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the GetMerchantArgs model.
    /// </summary>
    public class GetMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Merchant identity to extract
    /// </summary>
    /// <value>The merchant identifier.</value>
    public Guid MerchantId { get; set; }

    }
}