
using System;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the SaveMerchantAccountInfoArgs model.
    /// </summary>
    public class SaveMerchantAccountInfoArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The target bank account for the direct payment.
    /// </summary>
    /// <value>Must be a valid, active AccountModel (e.g., accountNumber, routingNumber) belonging to the payer; cannot be null.</value>
    public AccountModel Account { get; set; }

    /// <summary>
    /// The 6-digit TOTP code from the user's authenticator app. Set to null on first call. If response indicates CodeRequired, prompt user and retry with code.
    /// </summary>
    public string TwoFactorCode { get; set; }

    /// <summary>
    /// The bank account number provided by the user for security verification before 2FA setup. Required when TwoFactorStatus is SecurityVerificationRequired. Format: "BankNumber-Transit-AccountNumber" (e.g., "123-12345-123456789").
    /// </summary>
    public string TwoFactorSecurityAnswer { get; set; }

    }
}