
using System;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the WalletOperationDetailModel model.
    /// </summary>
    public class WalletOperationDetailModel 
    {
        
    /// <summary>
    /// Date and time the wallet movement was recorded.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Whether the money left the wallet.
    /// </summary>
    public bool IsWithdrawn { get; set; }

    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// Movement category: PaymentSettlement, Fees, WithdrawalToBank, WalletFunding, OutgoingDeposit, Adjustment, Reversal or Other.
    /// </summary>
    public string Category { get; set; }

    }
}