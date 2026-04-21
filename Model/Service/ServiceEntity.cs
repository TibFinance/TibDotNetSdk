
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
    /// The name of the service that processed the transfer
    /// </summary>
    /// <value>String, non‑empty, max length 64 characters; reflects the internal service identifier returned in the ListTransfers response</value>
    public string ServiceName { get; set; }

    /// <summary>
    /// The default language assigned to the customer for all platform communications.
    /// </summary>
    /// <value>Returned as a LanguageEnum code (e.g., EN, DE, FR). Read‑only; reflects the language set in the customer's profile and may be null if no default is configured.</value>
    public LanguageEnum DefaultCustomerLanguage { get; set; }

    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum? ProviderType { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    }
}