
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the RevertTransferArgs model.
    /// </summary>
    public class RevertTransferArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}