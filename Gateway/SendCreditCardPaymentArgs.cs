
using System;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Gateway
{
    /// <summary>
    /// Represents the SendCreditCardPaymentArgs model.
    /// </summary>
    public class SendCreditCardPaymentArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Manages all operations associated with credit card data.
    /// </summary>
    /// <value>Represents a distinct numerical identifier that corresponds to a specific credit card in the system.</value>
    public CreditCardModel CreditCard { get; set; }

    /// <summary>
    /// Specifies the amount to be paid. The value must not exceed the sum of the associated bill amount and any previously recorded payments. If null, the system applies the remaining unpaid portion of the bill.
    /// </summary>
    /// <value>The monetary amount of the payment, expressed as a decimal number.</value>
    public decimal PaymentAmount { get; set; }

    }
}