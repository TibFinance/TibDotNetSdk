
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the CreateServiceFromPublicTokenArgs model.
    /// </summary>
    public class CreateServiceFromPublicTokenArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the service associated with a merchant in the TIB Finance API. This property is crucial for managing service-related operations, including contract management and fee determination.
    /// </summary>
    /// <value>Represents the service entity linked to a merchant, encapsulating details necessary for API interactions.</value>
    public ServiceEntity Service { get; set; }

    /// <summary>
    /// Gets or sets the address associated with the entity.
    /// </summary>
    /// <value>The address represented by an AddressModel object.</value>
    public AddressModel Address { get; set; }

    /// <summary>
    /// Gets or sets the services fee.
    /// </summary>
    /// <value>The services fee.</value>
    public ServiceFeeSettingsModel ServicesFee { get; set; }

    /// <summary>
    /// Gets or sets the configuration settings for a TIB Finance service.
    /// </summary>
    /// <value>An instance of ServiceSettingsModel that defines the service's contract identifier, applicable limits, fees, and other operational parameters.</value>
    public ServiceSettingsModel ServiceSettings { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is primary.
    /// </summary>
    /// <value><c>true<c> if this instance is primary; otherwise, <c>false<c>.</value>
    public bool IsPrimary { get; set; }

    /// <summary>
    /// Gets or sets the bank address.
    /// </summary>
    /// <value>The bank address.</value>
    public string BankAddress { get; set; }

    /// <summary>
    /// Gets or sets the bank city.
    /// </summary>
    /// <value>The bank city.</value>
    public string BankCity { get; set; }

    /// <summary>
    /// Gets or sets the bank province.
    /// </summary>
    /// <value>The bank province.</value>
    public string BankProvince { get; set; }

    /// <summary>
    /// Gets or sets the bank country.
    /// </summary>
    /// <value>The bank country.</value>
    public string BankCountry { get; set; }

    /// <summary>
    /// Gets or sets the name of the bank.
    /// </summary>
    /// <value>The name of the bank.</value>
    public string BankName { get; set; }

    /// <summary>
    /// Identifies the bank associated with the account using its numeric identifier.
    /// </summary>
    /// <value>Holds the bank number as a string. The value must not exceed the allowed length.</value>
    public string BankNumber { get; set; }

    /// <summary>
    /// Gets or sets the bank transit.
    /// </summary>
    /// <value>The bank transit.</value>
    public string BankTransit { get; set; }

    /// <summary>
    /// Gets or sets the bank account.
    /// </summary>
    /// <value>The bank account.</value>
    public string BankAccount { get; set; }

    /// <summary>
    /// Gets or sets the owner email.
    /// </summary>
    /// <value>The owner email.</value>
    public string OwnerEmail { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    }
}