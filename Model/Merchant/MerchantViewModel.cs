
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.Merchant;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the MerchantViewModel model.
    /// </summary>
    public class MerchantViewModel 
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The name of the merchant associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty or null if the transfer has no merchant context.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// A masked representation of the account linked to the payment method.
    /// </summary>
    /// <value>String (max 34 chars) showing only the first and last few digits (e.g., '1234****5678'); empty if no account is associated.</value>
    public string AccountPreview { get; set; }

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
    /// The language used for the merchant's displayed information
    /// </summary>
    /// <value>Enum value from LanguageEnum (e.g., EN, DE, FR). Indicates the merchant's preferred language; may be omitted if not configured.</value>
    public LanguageEnum MerchantLanguage { get; set; }

    /// <summary>
    /// The merchant's primary contact email address.
    /// </summary>
    /// <value>A valid RFC 5322 email string, maximum 254 characters; may be null or omitted if no email is on record.</value>
    public string Email { get; set; }

    /// <summary>
    /// Indicates whether the caller is authorized to access the requested merchant data
    /// </summary>
    /// <value>True if the external ID matches a merchant the caller has permission to view; false otherwise. Always present in the response.</value>
    public bool IsAuthorized { get; set; }

    /// <summary>
    /// Email address(es) that receive a copy of the merchant's communications
    /// </summary>
    /// <value>String, optional, may contain a single email or a comma‑separated list of valid email addresses; maximum length 256 characters</value>
    public string EmailCopyTo { get; set; }

    /// <summary>
    /// The merchant's primary contact phone number.
    /// </summary>
    /// <value>String in E.164 format (e.g., +15551234567); may be null if not provided.</value>
    public string MerchantPhoneNumber { get; set; }

    /// <summary>
    /// The billing street address of the cardholder for the credit card payment method.
    /// </summary>
    /// <value>Required string, up to 100 characters, must be a valid street address; cannot contain line breaks or special characters beyond standard punctuation.</value>
    public string StreetAddress { get; set; }

    /// <summary>
    /// The city component of the billing address for the credit card.
    /// </summary>
    /// <value>String, required; max 50 characters; must contain only alphanumeric characters, spaces, hyphens, or periods.</value>
    public string AddressCity { get; set; }

    /// <summary>
    /// Identifier of the province or state for the billing address.
    /// </summary>
    /// <value>Required input; must be a valid value from ProvinceStateIdEnum; case‑sensitive; corresponds to the jurisdiction of the cardholder's billing address; omit only if the selected country has no subdivisions.</value>
    public ProvinceStateIdEnum ProvinceStateId { get; set; }

    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Identifier of the card‑issuing country for the payment method
    /// </summary>
    /// <value>Must be a valid CountryIdEnum value representing a supported country; required for all credit‑card payments and case‑sensitive.</value>
    public CountryIdEnum CountryId { get; set; }

    /// <summary>
    /// The postal ZIP code of the cardholder’s billing address.
    /// </summary>
    /// <value>String, required; must match the postal code format of the cardholder’s country (e.g., 5‑digit US ZIP or alphanumeric international code), typically 3‑10 characters.</value>
    public string PostalZipCode { get; set; }

    /// <summary>
    /// Identifies the external payment provider associated with the merchant.
    /// </summary>
    /// <value>Enum defined by ProviderEnum (e.g., Stripe, PayPal, Square). Present only for merchants linked via an external ID; may be null if the provider is not applicable.</value>
    public ProviderEnum? AccountProvider { get; set; }

    /// <summary>
    /// Identifier of the white‑label partner linked to the merchant, if any.
    /// </summary>
    /// <value>Nullable GUID; present only when the merchant is part of a white‑label arrangement, otherwise null. Must be a valid UUID when provided.</value>
    public Nullable<Guid> WhiteLabelingId { get; set; }

    /// <summary>
    /// Indicates the current onboarding state of the merchant identified by the external ID
    /// </summary>
    /// <value>String value such as "Pending", "InReview", "Completed" or "Failed"; reflects the merchant's progress through TIB Finance's boarding workflow and is case‑sensitive.</value>
    public string BoardingStatus { get; set; }

    /// <summary>
    /// Identifier of the boarding information linked to the merchant
    /// </summary>
    /// <value>A valid GUID referencing the merchant's boarding information record; included only when such data exists</value>
    public Guid? BoardingInformationId { get; set; }

    /// <summary>
    /// A list of boarding file records linked to the merchant identified by the external ID.
    /// </summary>
    /// <value>Contains zero or more BoardingFileModel objects, each describing a file (e.g., name, type, upload date, status). Read‑only in the response; may be empty if no files are associated. The list size is limited by platform storage policies.</value>
    public List<BoardingFileModel> BoardingFiles { get; set; }

    }
}