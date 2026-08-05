
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionIdentity model.
    /// </summary>
    public class TransactionIdentity : ProviderTransactionIdentity
    {
        
    /// <summary>
    /// Gets or sets the transaction identifier.
    /// </summary>
    /// <value>The transaction identifier.</value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Unique identifier of the merchant linked to the recurring transfer.
    /// </summary>
    /// <value>Guid; present only when the transfer is associated with a merchant, otherwise null. Read‑only and must be a valid GUID.</value>
    public Guid RelatedMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string LastExecutionDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal TransactionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime OriginalTransactionDueDatePassedWeekend { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime OriginalTransactionCreatedDatePassedWeekend { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public Guid? PayoutId { get; set; }

    }
}