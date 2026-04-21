
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the SaveMerchantResponse model.
    /// </summary>
    public class SaveMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Indicates the current two‑factor authentication state of the merchant account.
    /// </summary>
    /// <value>Enum TwoFactorStatus (e.g., ENABLED, DISABLED, PENDING). Returned only for accounts supporting 2FA; may be null if not applicable. Read‑only.</value>
    public TwoFactorStatus TwoFactorStatus { get; set; }

    /// <summary>
    /// Message returned to the client describing the outcome of the two‑factor authentication step.
    /// </summary>
    /// <value>String, up to 256 characters; may be empty if 2FA is not required or succeeded without additional prompts.</value>
    public string TwoFactorMessage { get; set; }

    /// <summary>
    /// Details of the merchant's two‑factor authentication configuration returned after saving account info
    /// </summary>
    /// <value>Contains fields such as enabled (bool), method (e.g., TOTP, SMS), secretKey (masked), qrCodeUrl, and setupTimestamp. Present only when 2FA is active; omitted or null otherwise.</value>
    public TwoFactorSetupData TwoFactorSetupData { get; set; }

    /// <summary>
    /// Unique identifier of the merchant associated with the two‑factor verification.
    /// </summary>
    /// <value>Guid; included only when two‑factor verification applies, otherwise may be null.</value>
    public Guid? TwoFactorVerificationMerchantId { get; set; }

    /// <summary>
    /// The merchant's display name used during two‑factor verification.
    /// </summary>
    /// <value>String, up to 100 characters, exactly as registered in the merchant profile; may be empty if two‑factor verification is not enabled.</value>
    public string TwoFactorVerificationMerchantName { get; set; }

    }
}