
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Transfer
{
    /// <summary>
    /// Represents the RelaunchMerchantFailedTransferArgs model.
    /// </summary>
    public class RelaunchMerchantFailedTransferArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    }
}