
using System;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the CreditCardModel model.
    /// </summary>
    public class CreditCardModel 
    {
        
    /// <summary>
    /// A textual description of the credit card to be used for the payment method.
    /// </summary>
    /// <value>Free‑form string (max 100 characters) identifying the card (e.g., brand, last four digits). Must not contain line breaks or control characters.</value>
    public string CreditCardDescription { get; set; }

    /// <summary>
    /// The numeric Primary Account Number (PAN) of the credit card.
    /// </summary>
    /// <value>Unsigned 64‑bit integer containing up to 19 digits; must pass Luhn validation and represent a valid, active card number.</value>
    public ulong Pan { get; set; }

    /// <summary>
    /// Card Verification Data (CVD) code for the credit card
    /// </summary>
    /// <value>Three‑digit (Visa/MasterCard/Discover) or four‑digit (American Express) numeric string; required for the payment; must be transmitted securely (TLS) and not stored.</value>
    public string CVD { get; set; }

    /// <summary>
    /// The two‑digit month (1‑12) in which the credit card expires.
    /// </summary>
    /// <value>Integer 1‑12; required; must represent a month that, together with ExpirationYear, is not in the past.</value>
    public int ExpirationMonth { get; set; }

    /// <summary>
    /// The four‑digit year when the credit card expires.
    /// </summary>
    /// <value>Must be a valid future year (e.g., 2025) and typically expressed as a four‑digit integer; values earlier than the current year are rejected.</value>
    public int ExpirationYear { get; set; }

    /// <summary>
    /// Name of the cardholder as printed on the credit card
    /// </summary>
    /// <value>Required string, up to 100 characters, alphabetic characters and spaces only; must match the card's billing name</value>
    public string CardOwner { get; set; }

    /// <summary>
    /// The billing address associated with the credit card being added.
    /// </summary>
    /// <value>Must be a valid AddressModel (street, city, postal code, country) matching the card issuer's records; required for verification and fraud checks.</value>
    public AddressModel CreditCardRegisteredAddress { get; set; }

    }
}