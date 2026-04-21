
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
    /// The fee amount applied to a credit‑card transfer when the convenient fee option is used.
    /// </summary>
    /// <value>Decimal value in the account's currency, typically with two decimal places; may be zero if no fee applies.</value>
    public decimal? ConvenientFeeCreditCard { get; set; }

    /// <summary>
    /// The convenience fee charged for a direct account transfer.
    /// </summary>
    /// <value>Decimal amount in the transaction currency, typically with two decimal places; may be zero if no fee applies.</value>
    public decimal? ConvenientFeeDirectAccount { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    }
}