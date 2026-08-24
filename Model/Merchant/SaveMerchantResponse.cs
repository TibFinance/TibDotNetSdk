
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
    /// Indicates the 2FA status of the operation. Check this value to determine if the operation succeeded or if 2FA action is needed.
    /// </summary>
    public TwoFactorStatus TwoFactorStatus { get; set; }

    /// <summary>
    /// Human-readable message explaining the 2FA status. Currently not localized to the caller's language; drive UX from TwoFactorStatus instead.
    /// </summary>
    public string TwoFactorMessage { get; set; }

    /// <summary>
    /// Setup data for 2FA enrollment. Populated only when TwoFactorStatus is SetupRequired. Contains QR code and manual entry key for authenticator app setup.
    /// </summary>
    public TwoFactorSetupData TwoFactorSetupData { get; set; }

    /// <summary>
    /// The ID of the merchant used for security verification. Populated when TwoFactorStatus is SecurityVerificationRequired or SecurityVerificationFailed.
    /// </summary>
    public Guid? TwoFactorVerificationMerchantId { get; set; }

    /// <summary>
    /// The name of the merchant used for security verification. Populated when TwoFactorStatus is SecurityVerificationRequired or SecurityVerificationFailed. Display in prompt: "Enter bank account for [MerchantName]"
    /// </summary>
    public string TwoFactorVerificationMerchantName { get; set; }

    }
}