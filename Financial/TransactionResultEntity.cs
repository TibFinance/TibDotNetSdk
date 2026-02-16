
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionResultEntity model.
    /// </summary>
    public class TransactionResultEntity : TransactionIdentity
    {
        
    /// <summary>
    /// Gets or sets the description associated with a transaction.
    /// </summary>
    /// <value>A textual description that provides context or details about the transaction. The value must be a non‑null string.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// Gets or sets the result of a banking operation as defined by the BankingOperationResultEnum.
    /// </summary>
    /// <value>The value indicating the outcome of the banking operation.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// Gets or sets the banking operation description.
    /// </summary>
    /// <value>The banking operation description.</value>
    public string BankingOperationDescription { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public OperationStatusEnum OperationStatus { get; set; }

    /// <summary>
    /// Gets or sets the real due date.
    /// </summary>
    /// <value>The real due date.</value>
    public DateTime? RealDueDate { get; set; }

    /// <summary>
    /// Gets or sets ProviderTransactionAdditionalInfos.
    /// </summary>
    /// <value>The ProviderTransactionAdditionalInfos.</value>
    public string ProviderTransactionAdditionalInfos { get; set; }

    /// <summary>
    /// Gets or sets the Processing Fees.
    /// </summary>
    /// <value>The Processing Fees.</value>
    public decimal? ProcessingFee { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ContainsPayoutData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal? ProviderPayoutFeeAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal? ProviderPayoutDepositAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PayoutReportData PayoutReportData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ContainsPayoutReportData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ForceCreateWebhookEvent { get; set; }

    }
}