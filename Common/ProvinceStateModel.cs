
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
    /// Gets or sets the identifier of the country using the CountryIdEnum enumeration. This identifier is required when specifying the country for client, service, or merchant operations.
    /// </summary>
    /// <value>The current CountryIdEnum value representing the selected country.</value>
    public CountryIdEnum CountryId { get; set; }

    /// <summary>
    /// Gets or sets the country abreviation.
    /// </summary>
    /// <value>The country abreviation.</value>
    public string CountryAbreviation { get; set; }

    /// <summary>
    /// Represents the unique identifier for a province or state within the system.
    /// </summary>
    /// <value>This identifier is used to specify a particular province or state, facilitating region-specific operations.</value>
    public ProvinceStateIdEnum ProvinceStateId { get; set; }

    /// <summary>
    /// Gets or sets the province abreviation.
    /// </summary>
    /// <value>The province abreviation.</value>
    public string ProvinceAbreviation { get; set; }

    }
}