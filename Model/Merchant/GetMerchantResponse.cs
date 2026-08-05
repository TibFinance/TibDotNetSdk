
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

    /// <summary>
    /// True when supplier payments are blocked for this merchant. The value is inherited from TIB configuration: the setting on the merchant's service takes precedence, then the client's service-wide default, then the client-level setting; merchant-level settings do not participate. When none is configured, supplier payments are allowed. Lets a merchant-login portal hide the supplier menu without a second settings call. Additive — absent/false means not denied.
    /// </summary>
    /// <value></value>
    public bool DenySupplierPayments { get; set; }

    }
}