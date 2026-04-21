
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the ProcessDropInCreditCardArgs model.
    /// </summary>
    public class ProcessDropInCreditCardArgs : BaseProcessDropInArgs
    {
        
    /// <summary>
    /// Credit card data supplied to fund the payment
    /// </summary>
    /// <value>Object containing cardNumber (16‑digit numeric, Luhn‑validated), expiryMonth (01‑12), expiryYear (YY or YYYY, not past), cvv (3‑4 digits), cardholderName (ASCII, ≤ 26 chars). Must be PCI‑DSS compliant: transmitted over TLS and stored only as a token. Supported schemes: Visa, MasterCard, Amex, Discover. All fields are required.</value>
    public CreditCardModel CreditCard { get; set; }

    }
}