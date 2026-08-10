
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ContactInfoModel model.
    /// </summary>
    public class ContactInfoModel 
    {
        
    /// <summary>
    /// The merchant's primary contact email address.
    /// </summary>
    /// <value>A valid RFC 5322 email string, maximum 254 characters; may be null or omitted if no email is on record.</value>
    public string Email { get; set; }

    /// <summary>
    /// Contact phone number.
    /// </summary>
    public string Phone { get; set; }

    /// <summary>
    /// The merchant's physical address.
    /// </summary>
    /// <value>An AddressModel containing street, city, state/province, postal code, and country; all fields required, must be a valid, non‑null address.</value>
    public string Address { get; set; }

    /// <summary>
    /// City name.
    /// </summary>
    public string City { get; set; }

    /// <summary>
    /// Province or state.
    /// </summary>
    public int? Province { get; set; }

    /// <summary>
    /// Country name.
    /// </summary>
    public int? Country { get; set; }

    /// <summary>
    /// Postal or ZIP code.
    /// </summary>
    public string ZipCode { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public int Language { get; set; }

    }
}