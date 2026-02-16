
using System;
using Tib.Api.Financial;
using Tib.Api.Model.Merchant;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the MerchantModel model.
    /// </summary>
    public class MerchantModel : MerchantModelBasicInfo
    {
        
    /// <summary>
    /// Contains the necessary details for replacing a merchant's account information within the system.
    /// </summary>
    /// <value>This model represents the account details associated with a merchant, ensuring that all relevant information is accurately captured and stored.</value>
    public AccountModel Account { get; set; }

    }
}