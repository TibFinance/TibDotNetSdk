
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the DeleteMerchantArgs model.
    /// </summary>
    public class DeleteMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Merchant identity to be remove. Cannot be the primary merchant.
    /// </summary>
    /// <value>The merchant identifier.</value>
    public Guid MerchantId { get; set; }

    }
}