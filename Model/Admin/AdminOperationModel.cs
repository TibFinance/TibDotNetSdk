
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AdminOperationModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid? TransferId { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public Guid? DependentOperationId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? TransactionGroupId { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the execution date and time of the transaction.
    /// </summary>
    /// <value>A DateTime value indicating when the transaction was executed, stored in UTC.</value>
    public DateTime? ExecutedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? ProcessDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? OperationsGroupId { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public TibOperationStatus OperationStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RevertProviderTransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? OverloadedMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsArchived { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? RevertProviderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RevertProviderTransactionAdditionalInfos { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
    public Guid? RelatedMerchantId { get; set; }

    /// <summary>
    /// Identifies the customer linked to this payment, when a customer relationship exists.
    /// </summary>
    /// <value>The unique GUID that references the associated customer record.</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsChecked { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public AcpOperationTypeEnum AcpTransactionType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OperationTargetValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CurrencyValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OperationDirectionValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OperationStatusValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OperationKindValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AcpTransactionTypeValue { get; set; }

    }
}