
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the BaseCreateCreditCardPaymentMethodArgs model.
    /// </summary>
    public class BaseCreateCreditCardPaymentMethodArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Indicates whether this payment method is configured as the customer's automatic payment method.
    /// </summary>
    /// <value>True if the method will be used for automatic payments, false otherwise. Only applicable to payment methods that support auto‑pay; the flag is read‑only in this response.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// Credit card data supplied to fund the payment
    /// </summary>
    /// <value>Object containing cardNumber (16‑digit numeric, Luhn‑validated), expiryMonth (01‑12), expiryYear (YY or YYYY, not past), cvv (3‑4 digits), cardholderName (ASCII, ≤ 26 chars). Must be PCI‑DSS compliant: transmitted over TLS and stored only as a token. Supported schemes: Visa, MasterCard, Amex, Discover. All fields are required.</value>
    public CreditCardModel CreditCard { get; set; }

    }
}