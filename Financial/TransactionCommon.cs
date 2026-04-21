
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionCommon model.
    /// </summary>
    public class TransactionCommon 
    {
        
    /// <summary>
    /// Specifies the destination entity of the transfer returned by ListTransfers
    /// </summary>
    /// <value>Enum values: ACCOUNT (internal account), WALLET (user wallet), EXTERNAL (outside TIB Finance). Always present; case‑sensitive; used to route subsequent actions.</value>
    public OperationTargetEnum OperationTarget { get; set; }

    /// <summary>
    /// The kind of operation the transfer represents
    /// </summary>
    /// <value>Enum value from OperationTypeEnum (e.g., CREDIT, DEBIT, REVERSAL, etc.); always present in the ListTransfers response and defines the transfer direction or special action.</value>
    public OperationTypeEnum OperationType { get; set; }

    /// <summary>
    /// Indicates whether the listed transfer is inbound to or outbound from the queried account
    /// </summary>
    /// <value>Enum TransferDirectionEnum; possible values: INBOUND, OUTBOUND. Read‑only field present in every ListTransfers response item.</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Indicates the current status of the transfer operation.
    /// </summary>
    /// <value>Read‑only enum (OperationStatusEnum) with values such as PENDING, COMPLETED, FAILED, CANCELED; reflects the final processing outcome of the transfer.</value>
    public OperationStatusEnum Status { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// Indicates the outcome of the banking operation for each listed transfer
    /// </summary>
    /// <value>Enum values (e.g., SUCCESS, FAILED, PENDING, REJECTED). Returned for every transfer; never null. Reflects the final processing status as recorded by the banking system.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// The name of the bank associated with the transfer.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty if the bank is not identified; reflects the bank's official name as provided by the originating institution.</value>
    public string BankDescription { get; set; }

    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// A short preview of the account involved in the transfer.
    /// </summary>
    /// <value>String showing account name and masked number (e.g., "Savings ****1234"); max 100 characters; may be empty if no account is linked.</value>
    public string AccoutPreview { get; set; }

    /// <summary>
    /// The type of payment method used for the transfer.
    /// </summary>
    /// <value>Enum PaymentMethodTypeEnum (e.g., BANK_ACCOUNT, CREDIT_CARD, DEBIT_CARD, WALLET). Always present in the response; reflects the source or destination account category.</value>
    public PaymentMethodTypeEnum AccountType { get; set; }

    /// <summary>
    /// A free‑form text describing the purpose or details of the transfer.
    /// </summary>
    /// <value>Returned as a string; may be empty if no description was provided. Maximum length 255 characters; UTF‑8 encoded.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// The scheduled date and time when the listed transfer is due to be executed.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp. Must be a future date for pending transfers; may be null for immediate or completed transfers.</value>
    public DateTime TransactionDueDate { get; set; }

    /// <summary>
    /// The date and time when the transfer record was last modified.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp (e.g., 2023-07-15T14:30:00Z). Read‑only; may be null if the transfer has never been updated.</value>
    public DateTime? LastModifiedDate { get; set; }

    }
}