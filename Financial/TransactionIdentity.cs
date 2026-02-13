
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransactionIdentity : ProviderTransactionIdentity
    {
        
    /// <summary>
    /// Gets or sets the transaction identifier.
    /// </summary>
    /// <value>The transaction identifier.</value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
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
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? PayoutId { get; set; }

    }
}