
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
    /// <value></value>
    public TwoFactorStatus TwoFactorStatus { get; set; }

    /// <summary>
    /// Localized message explaining the 2FA status. Display this to the user (e.g., "Please enter your authentication code").
    /// </summary>
    /// <value></value>
    public string TwoFactorMessage { get; set; }

    /// <summary>
    /// Setup data for 2FA enrollment. Populated only when TwoFactorStatus is SetupRequired. Contains QR code and manual entry key for authenticator app setup.
    /// </summary>
    /// <value></value>
    public TwoFactorSetupData TwoFactorSetupData { get; set; }

    /// <summary>
    /// The ID of the merchant used for security verification. Populated when TwoFactorStatus is SecurityVerificationRequired or SecurityVerificationFailed.
    /// </summary>
    /// <value></value>
    public Guid? TwoFactorVerificationMerchantId { get; set; }

    /// <summary>
    /// The name of the merchant used for security verification. Populated when TwoFactorStatus is SecurityVerificationRequired or SecurityVerificationFailed. Display in prompt: "Enter bank account for [MerchantName]"
    /// </summary>
    /// <value></value>
    public string TwoFactorVerificationMerchantName { get; set; }

    }
}