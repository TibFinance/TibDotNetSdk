
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
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Gets or sets the fee applied to credit‑card transactions when the convenient fee option is used.
    /// </summary>
    /// <value>A decimal value representing the credit‑card convenient fee expressed in the transaction currency.</value>
    public decimal? ConvenientFeeCreditCard { get; set; }

    /// <summary>
    /// Gets or sets the fee amount that is directly applied to the merchant's account for convenience services.
    /// </summary>
    /// <value>Decimal value representing the direct convenience fee charged to the account. The fee is expressed in the merchant's configured currency.</value>
    public decimal? ConvenientFeeDirectAccount { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    }
}