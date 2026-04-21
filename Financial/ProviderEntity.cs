
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderEntity model.
    /// </summary>
    public class ProviderEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int OrderPriority { get; set; }

    }
}