
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the CreateCreditCardGatewayArgs model.
    /// </summary>
    public class CreateCreditCardGatewayArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Indicates whether this payment method is configured as the customer's automatic payment method.
    /// </summary>
    /// <value>True if the method will be used for automatic payments, false otherwise. Only applicable to payment methods that support auto‑pay; the flag is read‑only in this response.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string provider { get; set; }

    /// <summary>
    /// Credit card data supplied to fund the payment
    /// </summary>
    /// <value>Object containing cardNumber (16‑digit numeric, Luhn‑validated), expiryMonth (01‑12), expiryYear (YY or YYYY, not past), cvv (3‑4 digits), cardholderName (ASCII, ≤ 26 chars). Must be PCI‑DSS compliant: transmitted over TLS and stored only as a token. Supported schemes: Visa, MasterCard, Amex, Discover. All fields are required.</value>
    public CreditCardModel CreditCard { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsCustomerPreAutorized { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsGatewayCall { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SkipValidation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsImmediate { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BinCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CardCategory { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CardSubType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CcBin { get; set; }

    /// <summary>
    /// The type of credit card used for the payment (e.g., Visa, MasterCard).
    /// </summary>
    /// <value>String; returned only for credit‑card payment methods. Expected values include Visa, MasterCard, Amex, Discover, etc. Case‑insensitive but typically capitalized.</value>
    public string CcType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IsRegulatedCard { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string IssuingCountry { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Token { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Exp { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Last4Digits { get; set; }

    /// <summary>
    /// Name of the cardholder as printed on the credit card
    /// </summary>
    /// <value>Required string, up to 100 characters, alphabetic characters and spaces only; must match the card's billing name</value>
    public string CardOwner { get; set; }

    /// <summary>
    /// Postal code of the cardholder's billing address
    /// </summary>
    /// <value>String, required; alphanumeric, up to 10 characters; must match the format expected by the issuing country (e.g., 5‑digit or ZIP+4 for US).</value>
    public string ZipCode { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType? RoutingType { get; set; }

    }
}