
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ServiceEntity model.
    /// </summary>
    public class ServiceEntity 
    {
        
    /// <summary>
    /// Retrieves or assigns the service's name.
    /// </summary>
    /// <value>This property holds the name of the service, which is crucial for identifying and managing the service within the TIB Finance system.</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// Retrieves or assigns the default language preference for a customer.
    /// </summary>
    /// <value>This property specifies the default language setting for a customer, allowing for personalized communication and interaction within the TIB Finance system.</value>
    public LanguageEnum DefaultCustomerLanguage { get; set; }

    /// <summary>
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>The type of the provider.</value>
    public ProviderEnum? ProviderType { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    }
}