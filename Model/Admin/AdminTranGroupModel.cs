
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the AdminTranGroupModel model.
    /// </summary>
    public class AdminTranGroupModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid TransactionGroupId { get; set; }

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
    /// Gets or sets the unique identifier of the target system used to reference the client’s contract within TIB Finance.
    /// </summary>
    /// <value>The target system identifier represented as a GUID.</value>
    public Guid TargetSystemId { get; set; }

    /// <summary>
    /// Specifies the target of an operation, indicating whether the operation pertains to the merchant or the customer.
    /// </summary>
    /// <value>Enum value that identifies the operation target.</value>
    public OperationTargetEnum OperationTarget { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public TransferDirectionEnum BaseOperationDirection { get; set; }

    /// <summary>
    /// Retrieves the identifier of the merchant (bank account) to which the operation applies.
    /// </summary>
    /// <value>A GUID assigned by TIB Finance during client account opening that uniquely identifies the merchant's primary account.</value>
    public Guid? RelatedMerchantId { get; set; }

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
    public string BaseOperationDirectionValue { get; set; }

    }
}