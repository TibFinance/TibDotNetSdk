
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProcessTransferEntity model.
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
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// The date by which the created payment must be settled.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be a future date, not earlier than the current date, and cannot exceed the platform's maximum scheduling horizon.</value>
    public DateTime DueDate { get; set; }

    /// <summary>
    /// A free‑form text describing the purpose or details of the transfer.
    /// </summary>
    /// <value>Returned as a string; may be empty if no description was provided. Maximum length 255 characters; UTF‑8 encoded.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// Gets or sets the type of the acp operation.
    /// </summary>
    /// <value>The type of the acp operation.</value>
    public AcpOperationTypeEnum AcpOperationType { get; set; }

    /// <summary>
    /// Gets or sets the transfer direction.
    /// </summary>
    /// <value>The transfer direction.</value>
    public TransferDirectionEnum TransferDirection { get; set; }

    /// <summary>
    /// The merchant's preferred payment provider.
    /// </summary>
    /// <value>Must be a valid ProviderEnum value representing a supported provider; case‑sensitive and required for processing the merchant's basic info.</value>
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
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
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
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid? TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<object> RelatedConvenientFeesWithTargetProviderId { get; set; }

    }
}