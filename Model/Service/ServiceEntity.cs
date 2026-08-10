
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
    /// Payment provider type for this service.
    /// </summary>
    public ProviderEnum? ProviderType { get; set; }

    /// <summary>
    /// Base currency for the service.
    /// </summary>
    public CurrencyEnum Currency { get; set; }

    }
}