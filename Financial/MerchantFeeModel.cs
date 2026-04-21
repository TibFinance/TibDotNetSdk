
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
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the merchant fees.
    /// </summary>
    /// <value>The merchant fees.</value>
    public TransactionFeesAgregatedModel MerchantFees { get; set; }

    }
}