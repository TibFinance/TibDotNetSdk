
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
    /// The merchant to delete. Cannot be the primary merchant.
    /// </summary>
    public Guid MerchantId { get; set; }

    }
}