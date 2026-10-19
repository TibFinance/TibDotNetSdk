
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSuppliersArgs model.
    /// </summary>
    public class ListSuppliersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The merchant ID to list suppliers for.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}