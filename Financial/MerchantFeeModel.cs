
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the MerchantFeeModel model.
    /// </summary>
    public class MerchantFeeModel 
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the merchant fees.
    /// </summary>
    /// <value>The merchant fees.</value>
    public TransactionFeesAgregatedModel MerchantFees { get; set; }

    }
}