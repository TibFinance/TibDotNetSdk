
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
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// This property holds the basic information necessary for creating or updating a merchant's account within the TIB Finance API system.
    /// </summary>
    /// <value>Contains essential details about the merchant.</value>
    public MerchantModel MerchantInfo { get; set; }

    }
}