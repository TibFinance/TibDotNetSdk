
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
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// Provides a secure representation of the account card number associated with a specific payment method.
    /// </summary>
    /// <value>The 'AccountPreview' property securely displays the account card number by masking certain digits, thereby safeguarding sensitive information.</value>
    public string AccountPreview { get; set; }

    /// <summary>
    /// Represents the unique identifier for a merchant within an external system. This ID is crucial for integrating and synchronizing merchant data across different platforms.
    /// </summary>
    /// <value>Serves as the external system identifier, linking the merchant to external databases or services.</value>
    public string ExternalSystemId { get; set; }

    /// <summary>
    /// Represents the external identity associated with a merchant within an external system.
    /// </summary>
    /// <value>Serves as the identifier for the group in an external system, facilitating the integration and management of merchant data across platforms.</value>
    public string ExternalSystemGroupId { get; set; }

    /// <summary>
    /// Defines the base currency utilized for bill creation by the merchant.
    /// </summary>
    /// <value>Specifies the currency in which the merchant operates, ensuring consistency in billing and transactions.</value>
    public CurrencyEnum MerchantCurrency { get; set; }

    /// <summary>
    /// Specifies the default language used by the merchant within the TIB Finance API. This setting is crucial for ensuring that all communications and operations are conducted in the preferred language of the merchant.
    /// </summary>
    /// <value>Defines the language preference for the merchant.</value>
    public LanguageEnum MerchantLanguage { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// Determines if the merchant is authorized to perform billing operations.
    /// </summary>
    /// <value>Returns <c>true</c> if the merchant is authorized; otherwise, returns <c>false</c>.</value>
    public bool IsAuthorized { get; set; }

    /// <summary>
    /// Specifies a list of email addresses, separated by semicolons, that will receive copies of emails sent to the merchant.
    /// </summary>
    /// <value>Represents the list of email addresses designated to receive email copies.</value>
    public string EmailCopyTo { get; set; }

    /// <summary>
    /// Represents the phone number associated with the merchant.
    /// </summary>
    /// <value>This property holds the phone number of the merchant, which is used for contact and verification purposes within the API.</value>
    public string MerchantPhoneNumber { get; set; }

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
    public ProvinceStateIdEnum ProvinceStateId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the country using the CountryIdEnum enumeration. This identifier is required when specifying the country for client, service, or merchant operations.
    /// </summary>
    /// <value>The current CountryIdEnum value representing the selected country.</value>
    public CountryIdEnum CountryId { get; set; }

    /// <summary>
    /// Gets or sets the postal zip code for the address entity.
    /// </summary>
    /// <value>The postal zip code string stored in the object.</value>
    public string PostalZipCode { get; set; }

    /// <summary>
    /// Gets or sets the account provider for the merchant or client account.
    /// </summary>
    /// <value>Specifies the external account provider. Acceptable values are defined in the ProviderEnum enumeration.</value>
    public ProviderEnum? AccountProvider { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for WhiteLabeling.
    /// </summary>
    /// <value>This property represents the unique identifier for a WhiteLabeling entity within the TIB Finance system. It is crucial for distinguishing between different WhiteLabeling configurations.</value>
    public Nullable<Guid> WhiteLabelingId { get; set; }

    /// <summary>
    /// Represents the status of the merchant boarding process within the system. This status is crucial for tracking the progress and completion of merchant onboarding.
    /// </summary>
    /// <value>The BoardingStatus does not require additional input parameters and is utilized within the standard API call structure to determine the current state of merchant onboarding.</value>
    public string BoardingStatus { get; set; }

    /// <summary>
    /// Represents the unique identifier for the boarding information of a merchant. This ID is crucial for tracking and referencing the boarding status within the system.
    /// </summary>
    /// <value>This property holds a GUID that uniquely identifies the boarding information associated with a merchant.</value>
    public Guid? BoardingInformationId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingFileModel> BoardingFiles { get; set; }

    }
}