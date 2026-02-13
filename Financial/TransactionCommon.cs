
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransactionCommon 
    {
        
    /// <summary>
    /// Specifies the target of an operation, indicating whether the operation pertains to the merchant or the customer.
    /// </summary>
    /// <value>Enum value that identifies the operation target.</value>
    public OperationTargetEnum OperationTarget { get; set; }

    /// <summary>
    /// Specifies the operation category used throughout the API.
    /// </summary>
    /// <value>Represents the operation type defined in the OperationTypeEnum, enabling the system to differentiate between deposit, collection, fee, and other transaction flows.</value>
    public OperationTypeEnum OperationType { get; set; }

    /// <summary>
    /// Specifies the direction of the operation, indicating whether funds are being collected or deposited.
    /// </summary>
    /// <value>A TransferDirectionEnum value that represents the operation direction (Collect or Deposit).</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public OperationStatusEnum Status { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the result of a banking operation as defined by the BankingOperationResultEnum.
    /// </summary>
    /// <value>The value indicating the outcome of the banking operation.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// Gets or sets the textual description of the bank associated with the transaction.
    /// </summary>
    /// <value>A string that contains the bank's description.</value>
    public string BankDescription { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or sets the preview text for a merchant account.
    /// </summary>
    /// <value>A string containing a concise, read‑only representation of the account, suitable for display in UI lists.</value>
    public string AccoutPreview { get; set; }

    /// <summary>
    /// Specifies the payment method type associated with the account.
    /// </summary>
    /// <value>Indicates whether the account is a Credit Card, Bank Account, or Interac payment method.</value>
    public PaymentMethodTypeEnum AccountType { get; set; }

    /// <summary>
    /// Gets or sets the description associated with a transaction.
    /// </summary>
    /// <value>A textual description that provides context or details about the transaction. The value must be a non‑null string.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// Retrieves or assigns the due date for a transaction.
    /// </summary>
    /// <value>Specifies the date by which the transaction is expected to be completed.</value>
    public DateTime TransactionDueDate { get; set; }

    /// <summary>
    /// Gets or sets the timestamp indicating when the entity was last modified.
    /// </summary>
    /// <value>Date and time of the most recent modification.</value>
    public DateTime? LastModifiedDate { get; set; }

    }
}