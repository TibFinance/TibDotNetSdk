
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the CreateCreditCardPaymentMethodArgs model.
    /// </summary>
    public class CreateCreditCardPaymentMethodArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Currency for the credit card payment method (CAD or USD).
    /// </summary>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

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

    /// <summary>
    /// Billing postal or ZIP code for AVS verification, for callers that collect only a postal code rather than a full billing address. Used only when CreditCard.CreditCardRegisteredAddress is not supplied — if a full registered address is provided, it takes precedence and this value is ignored.
    /// </summary>
    public string ZipCode { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    }
}