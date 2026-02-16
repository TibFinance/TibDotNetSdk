
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the CreateManualRefundForTransferOperationArgs model.
    /// </summary>
    public class CreateManualRefundForTransferOperationArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}