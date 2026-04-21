
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
    /// The target bank account for the direct payment.
    /// </summary>
    /// <value>Must be a valid, active AccountModel (e.g., accountNumber, routingNumber) belonging to the payer; cannot be null.</value>
    public AccountModel Account { get; set; }

    }
}