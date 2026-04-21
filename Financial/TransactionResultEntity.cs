
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
    /// A free‑form text describing the purpose or details of the transfer.
    /// </summary>
    /// <value>Returned as a string; may be empty if no description was provided. Maximum length 255 characters; UTF‑8 encoded.</value>
    public string TransactionDescription { get; set; }

    /// <summary>
    /// Indicates the outcome of the banking operation for each listed transfer
    /// </summary>
    /// <value>Enum values (e.g., SUCCESS, FAILED, PENDING, REJECTED). Returned for every transfer; never null. Reflects the final processing status as recorded by the banking system.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// Gets or sets the banking operation description.
    /// </summary>
    /// <value>The banking operation description.</value>
    public string BankingOperationDescription { get; set; }

    /// <summary>
    /// Indicates the result of the ListTransfers request
    /// </summary>
    /// <value>Integer status code where 0 = success; non‑zero values represent specific error conditions as defined in the API error code table.</value>
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