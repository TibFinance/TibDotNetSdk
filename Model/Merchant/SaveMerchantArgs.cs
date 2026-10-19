
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the SaveMerchantArgs model.
    /// </summary>
    public class SaveMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Merchant identitity to modify
    /// </summary>
    /// <value>The merchant identifier.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Basic merchant details required for creating or updating a merchant record
    /// </summary>
    /// <value>Object of type MerchantModelBasicInfo; must not be null and must contain all required fields (e.g., merchantName, taxId, contactEmail). Field lengths and formats follow the MerchantModelBasicInfo schema; optional fields may be omitted.</value>
    public MerchantModel MerchantInfo { get; set; }

    }
}