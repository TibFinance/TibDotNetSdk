
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderTransactionIdentity model.
    /// </summary>
    public class ProviderTransactionIdentity 
    {
        
    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// Gets or sets the transfer direction.
    /// </summary>
    /// <value>The transfer direction.</value>
    public TransferDirectionEnum TransferDirection { get; set; }

    /// <summary>
    /// Gets or sets the provider transaction identifier.
    /// </summary>
    /// <value>The provider transaction identifier.</value>
    public string ProviderTransactionId { get; set; }

    /// <summary>
    /// Gets or sets the provider transaction group identifier.
    /// </summary>
    /// <value>The provider transaction group identifier.</value>
    public string ProviderTransactionGroupId { get; set; }

    }
}