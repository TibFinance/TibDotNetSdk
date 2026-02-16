
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
    /// Gets or sets the unique identifier of a free‑collection operation. This GUID is assigned by TIB Finance when a free operation is created and is required to reference the operation in subsequent API calls.
    /// </summary>
    /// <value>A GUID that uniquely identifies a free collection operation within the TIB Finance system.</value>
    public Guid FreeCollectionId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the direction of the operation, indicating whether funds are being collected or deposited.
    /// </summary>
    /// <value>A TransferDirectionEnum value that represents the operation direction (Collect or Deposit).</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount associated with an operation.
    /// </summary>
    /// <value>The amount of the operation expressed in the transaction currency.</value>
    public decimal OperationAmount { get; set; }

    /// <summary>
    /// Current processing state of a transaction or operation.
    /// </summary>
    /// <value>Indicates the current status of the process using the ProcessStatusEnum values.</value>
    public ProcessStatusEnum CurrentStatus { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or sets the reference identifier used to uniquely identify a transaction, operation, or entity within the TIB Finance system.
    /// </summary>
    /// <value>A string containing the unique reference identifier. The identifier follows the GUID format supplied by TIB Finance.</value>
    public string ReferenceId { get; set; }

    /// <summary>
    /// Gets or sets the execution date and time of the transaction.
    /// </summary>
    /// <value>A DateTime value indicating when the transaction was executed, stored in UTC.</value>
    public DateTime? ExecutedDate { get; set; }

    /// <summary>
    /// Gets or sets the date and time when the transfer must be completed.
    /// </summary>
    /// <value>The due date of the transfer represented as a UTC DateTime.</value>
    public DateTime? TransferDueDate { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public int PaymentMethodType { get; set; }

    }
}