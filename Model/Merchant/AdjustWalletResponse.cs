
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the AdjustWalletResponse model.
    /// </summary>
    public class AdjustWalletResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// Whether the wallet adjustment was accepted and a transfer was created; false when a withdrawal is refused because the client's boarding is incomplete.
    /// </summary>
    /// <value></value>
    public bool WasSuccessful { get; set; }

    /// <summary>
    /// Indicates whether the supplier must complete onboarding before the wallet can be adjusted
    /// </summary>
    /// <value>True when supplier boarding is required, false otherwise; always present and non‑null in the response</value>
    public bool RequiresSupplierBoarding { get; set; }

    }
}