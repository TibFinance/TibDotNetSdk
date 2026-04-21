
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the TwoFactorSetupData model.
    /// </summary>
    public class TwoFactorSetupData 
    {
        
    /// <summary>
    /// Base64‑encoded image of the merchant's QR code.
    /// </summary>
    /// <value>String containing a valid Base64 representation of a PNG/JPEG QR code; size limited to 500 KB when decoded; used for displaying the merchant's payment QR code in client applications.</value>
    public string QrCodeBase64 { get; set; }

    /// <summary>
    /// A unique identifier returned when the merchant account was created via manual entry.
    /// </summary>
    /// <value>String; alphanumeric; present only for manually entered accounts; max length 64 characters.</value>
    public string ManualEntryKey { get; set; }

    /// <summary>
    /// URI to which the merchant must redirect the user to complete OTP authentication
    /// </summary>
    /// <value>String containing a valid HTTPS URL; present only when OTP is required, otherwise omitted or empty</value>
    public string OtpAuthUri { get; set; }

    /// <summary>
    /// The name or code of the financial institution that issued the merchant’s account.
    /// </summary>
    /// <value>String, typically the bank’s official name or ISO‑9362 BIC; max length 50 characters; may contain alphanumeric characters and spaces only.</value>
    public string Issuer { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    }
}