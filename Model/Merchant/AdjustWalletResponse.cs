
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
    /// Indicates whether the AdjustWallet request completed successfully
    /// </summary>
    /// <value>Boolean flag; true when the wallet adjustment was applied, false if it failed (e.g., validation error, insufficient funds). Always present in the response.</value>
    public bool WasSuccessful { get; set; }

    /// <summary>
    /// Indicates whether the supplier must complete onboarding before the wallet can be adjusted
    /// </summary>
    /// <value>True when supplier boarding is required, false otherwise; always present and non‑null in the response</value>
    public bool RequiresSupplierBoarding { get; set; }

    }
}