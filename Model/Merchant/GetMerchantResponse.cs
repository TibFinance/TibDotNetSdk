
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

    }
}