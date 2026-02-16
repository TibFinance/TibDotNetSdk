
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionSatusResultEntity model.
    /// </summary>
    public class TransactionSatusResultEntity 
    {
        
    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public OperationStatusEnum OperationStatus { get; set; }

    /// <summary>
    /// Gets or sets the result of a banking operation as defined by the BankingOperationResultEnum.
    /// </summary>
    /// <value>The value indicating the outcome of the banking operation.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankingOperationDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// Gets or sets the description associated with a transaction.
    /// </summary>
    /// <value>A textual description that provides context or details about the transaction. The value must be a non‑null string.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderTransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? RealDueDate { get; set; }

    }
}