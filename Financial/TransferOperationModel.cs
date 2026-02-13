
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferOperationModel 
    {
        
    /// <summary>
    /// Gets or sets the operation identifier.
    /// </summary>
    /// <value>The operation identifier.</value>
    public Guid OperationId { get; set; }

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
    /// Gets or sets the dependent operation.
    /// </summary>
    /// <value>The dependent operation.</value>
    public Guid? DependentOperation { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// Gets or sets the process date.
    /// </summary>
    /// <value>The process date.</value>
    public DateTime? ProcessDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? OverloadedMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? OverloadedProviderId { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public TibOperationStatus? OperationStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? HasUsedWallet { get; set; }

    /// <summary>
    /// Gets or sets the collection of transaction details associated with the operation.
    /// </summary>
    /// <value>Represents the list of TransactionCommon objects that describe each transaction performed within the operation.</value>
    public List<TransactionCommon> Transactions { get; set; }

    }
}