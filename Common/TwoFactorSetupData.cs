
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the TwoFactorSetupData model.
    /// </summary>
    public class TwoFactorSetupData 
    {
        
    /// <summary>
    /// Base64-encoded PNG image of the QR code for scanning with authenticator apps.
    /// </summary>
    public string QrCodeBase64 { get; set; }

    /// <summary>
    /// The secret key in Base32 format for manual entry into authenticator apps. Display this if the user cannot scan the QR code.
    /// </summary>
    public string ManualEntryKey { get; set; }

    /// <summary>
    /// Full otpauth:// URI for the TOTP entry. Can be used by API clients to generate their own QR code. Format: otpauth://totp/{Issuer}:{AccountName} with query parameters secret (the Base32 key) and issuer.
    /// </summary>
    public string OtpAuthUri { get; set; }

    /// <summary>
    /// The issuer name shown in the authenticator app. Currently always "TIB Portal". Matches the issuer embedded in OtpAuthUri; use this when presenting the manual-entry option.
    /// </summary>
    public string Issuer { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    }
}