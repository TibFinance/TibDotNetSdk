
using System;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ContactInfoModel model.
    /// </summary>
    public class ContactInfoModel 
    {
        
    /// <summary>
    /// Contact email address.
    /// </summary>
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
    /// Province or state, as an integer id: a ProvinceStateIdEnum value, such as 10 for Quebec or 8 for Ontario.
    /// </summary>
    public int? Province { get; set; }

    /// <summary>
    /// Country, as an integer id: a CountryIdEnum value, 1 for Canada or 2 for the United States.
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