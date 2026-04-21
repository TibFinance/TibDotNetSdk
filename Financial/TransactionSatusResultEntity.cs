
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
    /// Indicates the result of the ListTransfers request
    /// </summary>
    /// <value>Integer status code where 0 = success; non‑zero values represent specific error conditions as defined in the API error code table.</value>
    public OperationStatusEnum OperationStatus { get; set; }

    /// <summary>
    /// Indicates the outcome of the banking operation for each listed transfer
    /// </summary>
    /// <value>Enum values (e.g., SUCCESS, FAILED, PENDING, REJECTED). Returned for every transfer; never null. Reflects the final processing status as recorded by the banking system.</value>
    public BankingOperationResultEnum BankingOperationResult { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BankingOperationDescription { get; set; }

    /// <summary>
    /// Identifies the category of the service provider for the requested service
    /// </summary>
    /// <value>Returns a ProviderEnum value (e.g., BANK, BROKER, PAYMENT_GATEWAY). Must be one of the defined enum members; case‑sensitive and always present in the GetService response.</value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// A free‑form text describing the purpose or details of the transfer.
    /// </summary>
    /// <value>Returned as a string; may be empty if no description was provided. Maximum length 255 characters; UTF‑8 encoded.</value>
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