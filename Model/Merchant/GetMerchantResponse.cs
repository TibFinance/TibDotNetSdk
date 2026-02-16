
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the GetMerchantResponse model.
    /// </summary>
    public class GetMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides comprehensive information about a merchant, including essential details necessary for transaction processing.
    /// </summary>
    /// <value>Represents the merchant entity within the system, encapsulating both basic and account information.</value>
    public MerchantViewModel Merchant { get; set; }

    }
}