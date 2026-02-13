
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class FeeReportLineItem 
    {
        
    /// <summary>
    /// Gets or sets the operation identifier.
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid? TransferId { get; set; }

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
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public int Currency { get; set; }

    /// <summary>
    /// Gets or sets the fee type (OperationKind).
    /// </summary>
    /// <value></value>
    public OperationKindEnum FeeType { get; set; }

    /// <summary>
    /// Gets or sets the human-readable fee type description.
    /// </summary>
    /// <value></value>
    public string FeeTypeDescription { get; set; }

    /// <summary>
    /// Identifies the type of payment method linked to a specific account.
    /// </summary>
    /// <value>A unique identifier representing the type of the payment method.</value>
    public PaymentMethodTypeEnum? PaymentMethodType { get; set; }

    /// <summary>
    /// Gets or sets the human-readable payment method description.
    /// </summary>
    /// <value></value>
    public string PaymentMethodTypeDescription { get; set; }

    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// Gets or sets the external reference number from the transfer.
    /// </summary>
    /// <value></value>
    public string TransferExternalReference { get; set; }

    /// <summary>
    /// Retrieves the numeric status code of an operation.
    /// </summary>
    /// <value>The property holds an integer that identifies the current status of the operation.</value>
    public int OperationStatus { get; set; }

    }
}