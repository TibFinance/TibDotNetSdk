
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.TransferBatch;
using Tib.Api.Financial;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the TransferBatchItemModel model.
    /// </summary>
    public class TransferBatchItemModel 
    {
        
    /// <summary>
    /// Required: your reference for this payment, 1 to 150 printable ASCII characters (leading and trailing spaces are ignored), unique per merchant. Sending again a reference the merchant already used for a live payment with the same direction, payment method type, ImmediateTransfer setting, amount, due date and destination (the bank account, or the Interac recipient's email and phone) returns that payment (AlreadyCreated) instead of creating another; any other reuse is refused.
    /// </summary>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Required: FreeCollection (3) to collect from the customer, or FreeDeposit (2) to pay the customer. Other types are refused.
    /// </summary>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Required: DirectAccount (2) for a payment through the customer's bank account, sent in BankAccount, or Interac (3) for an Interac payment, sent in InteracInformation: an Interac deposit sends money and an Interac collection requests money. Interac is available only to merchants whose currency is CAD. Other types are refused.
    /// </summary>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// Required: the amount, from 0.01 to 500,000, with at most 2 decimals. An Interac collection is limited to 10,000, fees included.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// Required: the date the payment is due; only the date part is used. It cannot be in the past when the request is sent.
    /// </summary>
    public DateTime TransactionDueDate { get; set; }

    /// <summary>
    /// Optional: the text shown on the bank statement, 4 to 15 characters, and one of the descriptions authorized for the merchant's service. When absent, the merchant's default description is used.
    /// </summary>
    public string StatementDescription { get; set; }

    /// <summary>
    /// Optional: true sends a DirectAccount deposit as an instant deposit, at a merchant whose currency is CAD, only while immediate processing of deposits is enabled, and only when the merchant's wallet balance covers it together with the request's deposits that are not immediate and its earlier immediate ones; any other item that sets it is refused. Absent or false keeps the standard processing.
    /// </summary>
    public bool? ImmediateTransfer { get; set; }

    /// <summary>
    /// Required: the customer the payment is for.
    /// </summary>
    public TransferBatchCustomerModel Customer { get; set; }

    /// <summary>
    /// The customer's bank account: required when PaymentMethodType is DirectAccount, absent otherwise. Send the institution number in BankNumber (3 digits, or 4 with a leading zero) and the 5-digit branch transit in InstitutionNumber, or both as the 9-digit RoutingNumber; the holder name in Owner.
    /// </summary>
    public AccountModel BankAccount { get; set; }

    /// <summary>
    /// The Interac recipient: required when PaymentMethodType is Interac, absent otherwise. Send Owner and Description, TargetEmailAddress or TargetMobilePhoneNumber (or both), and for a deposit InteracQuestion and InteracAnswer; a collection ignores the question and answer. TargetEmailAddress is plain ASCII, 64 characters at most.
    /// </summary>
    public InteracModel InteracInformation { get; set; }

    }
}