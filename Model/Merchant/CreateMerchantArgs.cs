
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the CreateMerchantArgs model.
    /// </summary>
    public class CreateMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Basic merchant details required for creating or updating a merchant record
    /// </summary>
    /// <value>Object of type MerchantModelBasicInfo; must not be null and must contain all required fields (e.g., merchantName, taxId, contactEmail). Field lengths and formats follow the MerchantModelBasicInfo schema; optional fields may be omitted.</value>
    public MerchantModel MerchantInfo { get; set; }

    }
}