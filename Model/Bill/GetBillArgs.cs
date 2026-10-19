
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the GetBillArgs model.
    /// </summary>
    public class GetBillArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}