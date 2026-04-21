
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the FreeCollectionWithHierarchyModel model.
    /// </summary>
    public class FreeCollectionWithHierarchyModel 
    {
        
    /// <summary>
    /// Unique identifier of this free collection.
    /// </summary>
    /// <value></value>
    public Guid FreeCollectionId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer is inbound to or outbound from the queried account
    /// </summary>
    /// <value>Enum TransferDirectionEnum; possible values: INBOUND, OUTBOUND. Read‑only field present in every ListTransfers response item.</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Specifies the category of the transfer operation returned by the API
    /// </summary>
    /// <value>One of the OperationKindEnum values (e.g., DEPOSIT, WITHDRAWAL, INTERNAL, EXTERNAL). Always present in the response and limited to the defined enum members.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Dollar amount of the combined operation.
    /// </summary>
    /// <value></value>
    public decimal OperationAmount { get; set; }

    /// <summary>
    /// The current processing status of the transfer.
    /// </summary>
    /// <value>Read‑only enum (ProcessStatusEnum) indicating the latest state: Pending, InProgress, Completed, Failed, Cancelled, or Reversed. Returned only for transfers that have been processed.</value>
    public ProcessStatusEnum CurrentStatus { get; set; }

    /// <summary>
    /// The date and time when the recurring transfer was initially created.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; always present, immutable, and cannot be null.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// Unique identifier of the wallet information record returned by the service
    /// </summary>
    /// <value>A GUID that uniquely correlates the response to the request; must be a valid UUID format and remains constant for the lifetime of the record</value>
    public string ReferenceId { get; set; }

    /// <summary>
    /// The timestamp when the transfer was executed.
    /// </summary>
    /// <value>ISO‑8601 UTC datetime; present only for completed transfers, null for pending or failed ones.</value>
    public DateTime? ExecutedDate { get; set; }

    /// <summary>
    /// Scheduled execution date for the collection.
    /// </summary>
    /// <value></value>
    public DateTime? TransferDueDate { get; set; }

    /// <summary>
    /// The payment method type employed for the transfer.
    /// </summary>
    /// <value>A value from the PaymentMethodTypeEnum (e.g., CARD, BANK_ACCOUNT, WALLET). It identifies the source/destination method, is always present in the response, and must match one of the defined enum members.</value>
    public int PaymentMethodType { get; set; }

    }
}