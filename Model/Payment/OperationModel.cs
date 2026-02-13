
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Model.Payment;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class OperationModel 
    {
        
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
    /// Gets or sets the payment or merchant identifier.
    /// </summary>
    /// <value>The payment or merchant identifier.</value>
    public Guid PaymentOrMerchantId { get; set; }

    /// <summary>
    /// Gets or sets the collection of transaction details associated with the operation.
    /// </summary>
    /// <value>Represents the list of TransactionCommon objects that describe each transaction performed within the operation.</value>
    public List<TransactionCommon> Transactions { get; set; }

    /// <summary>
    /// Gets or sets the operation related payments.
    /// </summary>
    /// <value>The operation related payments.</value>
    public List<PaymentOperationWithHierarchy> OperationRelatedPayments { get; set; }

    }
}