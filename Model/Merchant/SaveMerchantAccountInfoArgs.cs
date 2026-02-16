
using System;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the SaveMerchantAccountInfoArgs model.
    /// </summary>
    public class SaveMerchantAccountInfoArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Contains the necessary details for replacing a merchant's account information within the system.
    /// </summary>
    /// <value>This model represents the account details associated with a merchant, ensuring that all relevant information is accurately captured and stored.</value>
    public AccountModel Account { get; set; }

    }
}