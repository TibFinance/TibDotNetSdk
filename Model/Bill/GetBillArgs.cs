
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the GetBillArgs model.
    /// </summary>
    public class GetBillArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}