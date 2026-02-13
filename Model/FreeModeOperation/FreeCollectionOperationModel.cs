
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Model.FreeModeOperation;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class FreeCollectionOperationModel 
    {
        
    /// <summary>
    /// Gets or sets the operation type reference identifier that categorizes an operation.
    /// </summary>
    /// <value>A string containing the operation type reference, typically formatted as a GUID.</value>
    public string OperationTypeRef { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the target of an operation, indicating whether the operation pertains to the merchant or the customer.
    /// </summary>
    /// <value>Enum value that identifies the operation target.</value>
    public OperationTargetEnum OperationTarget { get; set; }

    /// <summary>
    /// Specifies the direction of the operation, indicating whether funds are being collected or deposited.
    /// </summary>
    /// <value>A TransferDirectionEnum value that represents the operation direction (Collect or Deposit).</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Gets or sets the unique identifier of the target system used to reference the client’s contract within TIB Finance.
    /// </summary>
    /// <value>The target system identifier represented as a GUID.</value>
    public Guid TargetSystemId { get; set; }

    /// <summary>
    /// Gets or sets the collection of transaction details associated with the operation.
    /// </summary>
    /// <value>Represents the list of TransactionCommon objects that describe each transaction performed within the operation.</value>
    public List<TransactionCommon> Transactions { get; set; }

    /// <summary>
    /// Retrieves the collection of free‑operation records, each represented as a FreeCollectionWithHierarchyModel, ordered by their hierarchical relationship.
    /// </summary>
    /// <value>A list containing all free collection entries currently stored in the system.</value>
    public List<FreeCollectionWithHierarchyModel> FreeCollectionList { get; set; }

    }
}