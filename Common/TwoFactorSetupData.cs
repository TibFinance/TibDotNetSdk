
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
    /// <value></value>
    public string QrCodeBase64 { get; set; }

    /// <summary>
    /// The secret key in Base32 format for manual entry into authenticator apps. Display this if the user cannot scan the QR code.
    /// </summary>
    /// <value></value>
    public string ManualEntryKey { get; set; }

    /// <summary>
    /// Full otpauth: URI for the TOTP entry. Can be used by API clients to generate their own QR code. Format: otpauth:totpTIB Portal:username?secret=BASE32SECRET&issuer=TIB Portal
    /// </summary>
    /// <value></value>
    public string OtpAuthUri { get; set; }

    /// <summary>
    /// The issuer name shown in the authenticator app (e.g., "TIB Portal").
    /// </summary>
    /// <value></value>
    public string Issuer { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    }
}