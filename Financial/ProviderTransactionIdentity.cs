
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
    /// Gets or sets the type of the provider.
    /// </summary>
    /// <value>The type of the provider.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// Indicates the direction of an Interac transaction.
    /// </summary>
    /// <value>Use 1 for Collect (merchant receives funds from the customer) or 2 for Deposit (merchant sends funds to the customer).</value>
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