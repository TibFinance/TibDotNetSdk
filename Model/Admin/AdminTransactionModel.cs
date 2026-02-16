
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the AdminTransactionModel model.
    /// </summary>
    public class AdminTransactionModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid TransactionGroupId { get; set; }

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
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public OperationStatusEnum OperationStatus { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int? DescriptionCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderTransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderTransactionGroupId { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? NextStepTransaction { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public Guid AccountInformationId { get; set; }

    /// <summary>
    /// Specifies the payment method type associated with the account.
    /// </summary>
    /// <value>Indicates whether the account is a Credit Card, Bank Account, or Interac payment method.</value>
    public AccountTypeEnum? AccountType { get; set; }

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
    /// 
    /// </summary>
    /// <value></value>
    public AcpOperationTypeEnum? AcpTransactionType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ReceivedDescription { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? RealDueDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? DueDateUpdatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? ProcessExecuted { get; set; }

    /// <summary>
    /// Gets or sets the timestamp indicating when the entity was last modified.
    /// </summary>
    /// <value>Date and time of the most recent modification.</value>
    public DateTime? LastModifiedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool ExportBeenExecuted { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsRevert { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsArchived { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? FavoriteProviderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? ExecutedByProviderId { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderTransactionAdditionalInfos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
    public Guid RelatedMerchantId { get; set; }

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
    public List<Guid> MerchantIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> CustomerIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransferIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> OperationIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string OperationTypeValue { get; set; }

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
    public string AccountTypeValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AcpTransactionTypeValue { get; set; }

    }
}