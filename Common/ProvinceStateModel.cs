
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the ProvinceStateModel model.
    /// </summary>
    public class ProvinceStateModel 
    {
        
    /// <summary>
    /// Identifier of the card‑issuing country for the payment method
    /// </summary>
    /// <value>Must be a valid CountryIdEnum value representing a supported country; required for all credit‑card payments and case‑sensitive.</value>
    public CountryIdEnum CountryId { get; set; }

    /// <summary>
    /// Gets or sets the country abreviation.
    /// </summary>
    /// <value>The country abreviation.</value>
    public string CountryAbreviation { get; set; }

    /// <summary>
    /// Identifier of the province or state for the billing address.
    /// </summary>
    /// <value>Required input; must be a valid value from ProvinceStateIdEnum; case‑sensitive; corresponds to the jurisdiction of the cardholder's billing address; omit only if the selected country has no subdivisions.</value>
    public ProvinceStateIdEnum ProvinceStateId { get; set; }

    /// <summary>
    /// Gets or sets the province abreviation.
    /// </summary>
    /// <value>The province abreviation.</value>
    public string ProvinceAbreviation { get; set; }

    }
}