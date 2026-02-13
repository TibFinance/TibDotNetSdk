
using System;
using Tib.Api.Model.Payment;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreatePaymentArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid BillId { get; set; }

    /// <summary>
    /// Automatically assigns the customer linked to a payment from the customer associated with the specified bill. The method takes no action if the bill has no customer or if the payment already has a customer assigned.
    /// </summary>
    /// <value>Returns true when the payment's customer is set from the bill; otherwise returns false.</value>
    public bool SetPaymentCustomerFromBill { get; set; }

    /// <summary>
    /// Handles the acquisition and assignment of a customer's email address.
    /// </summary>
    /// <value>Represents a valid email address linked to a specific customer, provided as a string.</value>
    public string CustomerEmail { get; set; }

    /// <summary>
    /// Contains metadata for a payment operation.
    /// </summary>
    /// <value>Represents the core attributes of a payment, such as identifiers, amount, currency, status, and timestamps.</value>
    public PaymentEntity PaymentInfo { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the external reference identifier used to correlate this entity with an external system.
    /// </summary>
    /// <value>A string that uniquely identifies the entity in an external system.</value>
    public string ExternalReferenceId { get; set; }

    /// <summary>
    /// Indicates whether the system aborts a payment when the amount exceeds the remaining bill balance.
    /// </summary>
    /// <value>Set to true to stop the transaction if the payment amount is greater than the outstanding bill amount; set to false to allow the payment to proceed.</value>
    public bool SafetyToBreakIfOverRemainingBillAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public AutorizedPaymentMethodFlags? AutorizedPaymentMethod { get; set; }

    /// <summary>
    /// Indicates if the system must request the customer's consent prior to executing the payment.
    /// </summary>
    /// <value>Set to true to trigger a consent request; false skips the consent step.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// Specifies whether the payment creation request should omit sending the confirmation email.
    /// </summary>
    /// <value>True suppresses the email; false allows the email to be sent.</value>
    public bool DoNotSendEmail { get; set; }

    /// <summary>
    /// Indicates whether the transfer should be executed immediately within the TIB Finance API.
    /// </summary>
    /// <value>This boolean property determines if the transaction is processed instantly, bypassing any scheduled or delayed processing mechanisms.</value>
    public bool? ImmediateTransfer { get; set; }

    /// <summary>
    /// Represents a brief description used in statements to identify or clarify the transaction.
    /// </summary>
    /// <value>This string provides a concise description for transactions, aiding in the identification and clarification of statement entries.</value>
    public string StatementDescription { get; set; }

    }
}