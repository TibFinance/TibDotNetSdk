
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessTransferEntity 
    {
        
    /// <summary>
    /// Gets or sets the transaction identifier.
    /// </summary>
    /// <value>The transaction identifier.</value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Gets or sets the transaction group identifier.
    /// </summary>
    /// <value>The transaction group identifier.</value>
    public Guid TransactionGroupId { get; set; }

    /// <summary>
    /// Gets or sets the transaction amount.
    /// </summary>
    /// <value>The transaction amount.</value>
    public decimal TransactionAmount { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// Gets or sets the description associated with a transaction.
    /// </summary>
    /// <value>A textual description that provides context or details about the transaction. The value must be a non‑null string.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// Gets or sets the type of the acp operation.
    /// </summary>
    /// <value>The type of the acp operation.</value>
    public AcpOperationTypeEnum AcpOperationType { get; set; }

    /// <summary>
    /// Indicates the direction of an Interac transaction.
    /// </summary>
    /// <value>Use 1 for Collect (merchant receives funds from the customer) or 2 for Deposit (merchant sends funds to the customer).</value>
    public TransferDirectionEnum TransferDirection { get; set; }

    /// <summary>
    /// Gets or sets the favorite provider.
    /// </summary>
    /// <value>The favorite provider.</value>
    public Guid? FavoriteProvider { get; set; }

    /// <summary>
    /// True determine the transaction is process as "reverting" of existing operation, need to fill AlreadyProcessedProviderInfo.
    /// </summary>
    /// <value></value>
    public bool IsTransactionRevert { get; set; }

    /// <summary>
    /// Must be filled when IsTransactionRevert is set to true in order to be able to know what is the transaction to be reverted.
    /// </summary>
    /// <value></value>
    public string AlreadyProcessedProviderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AlreadyProcessedProviderAdditionalInfos { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderTransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderSubType { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<object> RelatedConvenientFeesWithTargetProviderId { get; set; }

    }
}