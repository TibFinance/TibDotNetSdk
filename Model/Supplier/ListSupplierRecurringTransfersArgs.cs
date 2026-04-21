
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierRecurringTransfersArgs model.
    /// </summary>
    public class ListSupplierRecurringTransfersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    }
}