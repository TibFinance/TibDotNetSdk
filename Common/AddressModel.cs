
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
    /// Represents the street address associated with a specific entity or location.
    /// </summary>
    /// <value>This property stores the street address information, which is crucial for identifying the physical location of an entity.</value>
    public string StreetAddress { get; set; }

    /// <summary>
    /// Retrieves or assigns the city component of an address.
    /// </summary>
    /// <value>Represents the city part of an address, typically used in postal addresses.</value>
    public string AddressCity { get; set; }

    /// <summary>
    /// Represents the unique identifier for a province or state within the system.
    /// </summary>
    /// <value>This identifier is used to specify a particular province or state, facilitating region-specific operations.</value>
    public ProvinceStateIdEnum? ProvinceStateId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the country using the CountryIdEnum enumeration. This identifier is required when specifying the country for client, service, or merchant operations.
    /// </summary>
    /// <value>The current CountryIdEnum value representing the selected country.</value>
    public CountryIdEnum? CountryId { get; set; }

    /// <summary>
    /// Gets or sets the postal zip code for the address entity.
    /// </summary>
    /// <value>The postal zip code string stored in the object.</value>
    public string PostalZipCode { get; set; }

    }
}