
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
    /// Identifier of the merchant whose transfers are being queried
    /// </summary>
    /// <value>String, required; must match the merchant's unique ID in TIB Finance; filters results to transfers created by or associated with this merchant</value>
    public MerchantViewModel Merchant { get; set; }

    }
}