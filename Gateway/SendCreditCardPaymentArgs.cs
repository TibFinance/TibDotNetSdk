
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
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Credit card data supplied to fund the payment
    /// </summary>
    /// <value>Object containing cardNumber (16‑digit numeric, Luhn‑validated), expiryMonth (01‑12), expiryYear (YY or YYYY, not past), cvv (3‑4 digits), cardholderName (ASCII, ≤ 26 chars). Must be PCI‑DSS compliant: transmitted over TLS and stored only as a token. Supported schemes: Visa, MasterCard, Amex, Discover. All fields are required.</value>
    public CreditCardModel CreditCard { get; set; }

    /// <summary>
    /// The monetary amount to be transferred in the transaction's currency.
    /// </summary>
    /// <value>Decimal, required, must be greater than 0, limited to two fractional digits, and must not exceed the payer's available balance or any configured transaction limits.</value>
    public decimal PaymentAmount { get; set; }

    }
}