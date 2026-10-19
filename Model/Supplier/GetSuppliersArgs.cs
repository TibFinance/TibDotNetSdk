
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the GetSuppliersArgs model.
    /// </summary>
    public class GetSuppliersArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Merchant identifier to retrieve suppliers for.
    /// </summary>
    public Guid MerchantId { get; set; }

    }
}