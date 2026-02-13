
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class MerchantModelBasicInfo 
    {
        
    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

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
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// Specifies a list of email addresses, separated by semicolons, that will receive copies of emails sent to the merchant.
    /// </summary>
    /// <value>Represents the list of email addresses designated to receive email copies.</value>
    public string EmailCopyTo { get; set; }

    /// <summary>
    /// The merchant's phone number used for contact and transaction notifications.
    /// </summary>
    /// <value>A string containing the merchant's telephone number. The value must conform to the allowed character set defined by the regular expression.</value>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Contains a free‑text description of the merchant, which is stored in the TIB Finance system and displayed in merchant records.
    /// </summary>
    /// <value>A UTF‑8 encoded string that describes the merchant. The description is optional but recommended for identification purposes.</value>
    public string MerchantDescription { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the entity.
    /// </summary>
    /// <value>The address represented by an AddressModel object.</value>
    public AddressModel Address { get; set; }

    /// <summary>
    /// Gets or sets the favorite provider.
    /// </summary>
    /// <value>The favorite provider.</value>
    public ProviderEnum? FavoriteProvider { get; set; }

    }
}