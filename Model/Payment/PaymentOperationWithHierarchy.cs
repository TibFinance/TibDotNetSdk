
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentOperationWithHierarchy model.
    /// </summary>
    public class PaymentOperationWithHierarchy 
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the payment group identifier.
    /// </summary>
    /// <value>The payment group identifier.</value>
    public string PaymentGroupId { get; set; }

    /// <summary>
    /// Gets or sets the monetary amount associated with an operation.
    /// </summary>
    /// <value>The amount of the operation expressed in the transaction currency.</value>
    public decimal OperationAmount { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the direction of the operation, indicating whether funds are being collected or deposited.
    /// </summary>
    /// <value>A TransferDirectionEnum value that represents the operation direction (Collect or Deposit).</value>
    public TransferDirectionEnum OperationDirection { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// Gets or sets the operation created date.
    /// </summary>
    /// <value>The operation created date.</value>
    public DateTime OperationCreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the related payment amount.
    /// </summary>
    /// <value>The related payment amount.</value>
    public decimal RelatedPaymentAmount { get; set; }

    /// <summary>
    /// Gets or sets the related payment convenient fees for credit card.
    /// </summary>
    /// <value>The related payment convenient fees for credit card.</value>
    public decimal? RelatedPaymentConvenientFeesForCreditCard { get; set; }

    /// <summary>
    /// Gets or sets the related payment convenient fees for direct account.
    /// </summary>
    /// <value>The related payment convenient fees for direct account.</value>
    public decimal? RelatedPaymentConvenientFeesForDirectAccount { get; set; }

    /// <summary>
    /// Gets or sets the related payment current status.
    /// </summary>
    /// <value>The related payment current status.</value>
    public ProcessStatusEnum RelatedPaymentCurrentStatus { get; set; }

    /// <summary>
    /// Gets or sets the related payment created date.
    /// </summary>
    /// <value>The related payment created date.</value>
    public DateTime RelatedPaymentCreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the related payment customer identifier.
    /// </summary>
    /// <value>The related payment customer identifier.</value>
    public Guid? RelatedPaymentCustomerId { get; set; }

    }
}