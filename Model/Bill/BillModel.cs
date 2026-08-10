
using System;
using Tib.Api.Model.Bill;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the BillModel model.
    /// </summary>
    public class BillModel : BillEntity
    {
        
    /// <summary>
    /// Unique identifier of the bill to be paid
    /// </summary>
    /// <value>Guid referencing an existing, unpaid bill; must be a valid, non‑empty GUID and belong to the requesting account</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Calculated convenience fee if paid by credit card. Always zero if UseConvenientFeeRule is false. This amount cannot be set. It is calculated by the system
    /// </summary>
    /// <value>The convenient fee credit card.</value>
    public decimal? ConvenientFeeCreditCard { get; set; }

    /// <summary>
    /// Calculated convenience fee if paid by direct account transfer. Always zero if UseConvenientFeeRule is false. This amount cannot be set. It is calculated by the system
    /// </summary>
    /// <value>The convenient fee direct account.</value>
    public decimal? ConvenientFeeDirectAccount { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    }
}