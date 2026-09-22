
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
    /// Whether supplier payments are blocked for this merchant. When true, calls that would make this merchant the payer of a supplier transfer are refused. Absent or false means supplier payments are allowed.
    /// </summary>
    public bool DenySupplierPayments { get; set; }

    /// <summary>
    /// The merchant's effective allowlist of collect payment methods, resolved the same way the hosted payment page enforces it, so a caller never offers a payment method the page would then refuse. Bit values are OR-ed: CreditCard 1, DirectAccount 2, Interac 16 (for example 18 = DirectAccount + Interac). 0 means no allowlist is recorded and nothing is restricted (every payment method is permitted, Interac included); only a non-zero value restricts, and a payment method may then be offered only when its bit is present.
    /// </summary>
    public int CollectAllowedPaymentMethods { get; set; }

    }
}