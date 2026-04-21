
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the MerchantModelBasicInfo model.
    /// </summary>
    public class MerchantModelBasicInfo 
    {
        
    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Identifier of the external system that owns the merchant ID
    /// </summary>
    /// <value>String (max 50 chars), required, case‑sensitive; must match the external system's unique identifier used to locate merchants linked to that system</value>
    public string ExternalSystemId { get; set; }

    /// <summary>
    /// Identifier of the external system group for the merchant lookup
    /// </summary>
    /// <value>String (max 50 chars), required, case‑sensitive, must correspond to an existing external system group; scopes the search performed by GetMerchantsByExternalId</value>
    public string ExternalSystemGroupId { get; set; }

    /// <summary>
    /// The currency in which the merchant conducts transactions.
    /// </summary>
    /// <value>A value from CurrencyEnum (e.g., USD, EUR, GBP); reflects the merchant's base currency and is required for all monetary fields in the response.</value>
    public CurrencyEnum MerchantCurrency { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// The merchant's primary contact email address.
    /// </summary>
    /// <value>A valid RFC 5322 email string, maximum 254 characters; may be null or omitted if no email is on record.</value>
    public string Email { get; set; }

    /// <summary>
    /// Email address(es) that receive a copy of the merchant's communications
    /// </summary>
    /// <value>String, optional, may contain a single email or a comma‑separated list of valid email addresses; maximum length 256 characters</value>
    public string EmailCopyTo { get; set; }

    /// <summary>
    /// The merchant's primary contact phone number.
    /// </summary>
    /// <value>String, required; must follow E.164 format (e.g., +1234567890), 10‑15 digits including country code, no spaces or special characters.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// A textual description of the merchant’s business and services.
    /// </summary>
    /// <value>Plain‑text string, up to 500 characters, required for new merchants; HTML tags are not allowed.</value>
    public string MerchantDescription { get; set; }

    /// <summary>
    /// The merchant's physical address.
    /// </summary>
    /// <value>An AddressModel containing street, city, state/province, postal code, and country; all fields required, must be a valid, non‑null address.</value>
    public AddressModel Address { get; set; }

    /// <summary>
    /// The merchant's preferred payment provider.
    /// </summary>
    /// <value>Must be a valid ProviderEnum value representing a supported provider; case‑sensitive and required for processing the merchant's basic info.</value>
    public ProviderEnum? FavoriteProvider { get; set; }

    }
}