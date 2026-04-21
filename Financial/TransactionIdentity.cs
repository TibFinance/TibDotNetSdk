
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
    /// <value></value>
    public string LastExecutionDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal TransactionAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime OriginalTransactionDueDatePassedWeekend { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime OriginalTransactionCreatedDatePassedWeekend { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? PayoutId { get; set; }

    }
}