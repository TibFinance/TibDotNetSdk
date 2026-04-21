
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the AddressModel model.
    /// </summary>
    public class AddressModel 
    {
        
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
    public ProvinceStateIdEnum? ProvinceStateId { get; set; }

    /// <summary>
    /// Identifier of the card‑issuing country for the payment method
    /// </summary>
    /// <value>Must be a valid CountryIdEnum value representing a supported country; required for all credit‑card payments and case‑sensitive.</value>
    public CountryIdEnum? CountryId { get; set; }

    /// <summary>
    /// The postal ZIP code of the cardholder’s billing address.
    /// </summary>
    /// <value>String, required; must match the postal code format of the cardholder’s country (e.g., 5‑digit US ZIP or alphanumeric international code), typically 3‑10 characters.</value>
    public string PostalZipCode { get; set; }

    }
}