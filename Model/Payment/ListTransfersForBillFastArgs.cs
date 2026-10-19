
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersForBillFastArgs model.
    /// </summary>
    public class ListTransfersForBillFastArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Merchant identifier that owns the bill.
    /// </summary>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid BillId { get; set; }

    }
}