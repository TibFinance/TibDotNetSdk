
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the PaymentMethodModel model.
    /// </summary>
    public class PaymentMethodModel 
    {
        
    /// <summary>
    /// Identifier of the payment method to be set as the default for the account
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID referencing an existing, active payment method owned by the caller; cannot be null or belong to another tenant.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Indicates whether this payment method is configured as the customer's automatic payment method.
    /// </summary>
    /// <value>True if the method will be used for automatic payments, false otherwise. Only applicable to payment methods that support auto‑pay; the flag is read‑only in this response.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// The payment method type employed for the transfer.
    /// </summary>
    /// <value>A value from the PaymentMethodTypeEnum (e.g., CARD, BANK_ACCOUNT, WALLET). It identifies the source/destination method, is always present in the response, and must match one of the defined enum members.</value>
    public PaymentMethodTypeEnum PaymentMethodType { get; set; }

    /// <summary>
    /// Descriptive name of the payment method used for the transfer.
    /// </summary>
    /// <value>Human‑readable string (e.g., "Bank Transfer", "Credit Card", "SEPA"); up to 100 characters; may be null if the method is not applicable.</value>
    public string PaymentMethodDescription { get; set; }

    /// <summary>
    /// A masked representation of the account linked to the payment method.
    /// </summary>
    /// <value>String (max 34 chars) showing only the first and last few digits (e.g., '1234****5678'); empty if no account is associated.</value>
    public string AccountPreview { get; set; }

    /// <summary>
    /// The date and time when the payment method expires.
    /// </summary>
    /// <value>ISO‑8601 UTC timestamp; may be null for perpetual methods; must be a future date at the time of retrieval.</value>
    public DateTime? ExpirationDate { get; set; }

    /// <summary>
    /// Identifier of the entity that owns the payment method.
    /// </summary>
    /// <value>String, non‑empty, typically a UUID or account ID representing the user or merchant; immutable for the lifetime of the method.</value>
    public string Owner { get; set; }

    /// <summary>
    /// The type of credit card used for the payment (e.g., Visa, MasterCard).
    /// </summary>
    /// <value>String; returned only for credit‑card payment methods. Expected values include Visa, MasterCard, Amex, Discover, etc. Case‑insensitive but typically capitalized.</value>
    public string CcType { get; set; }

    /// <summary>
    /// List of merchants (ID and name) that are pre‑authorized to use this payment method.
    /// </summary>
    /// <value>Read‑only array of MerchantIdName objects; may be empty if no merchants are pre‑authorized. Each entry contains a unique merchant identifier and its display name.</value>
    public List<MerchantIdName> PreauthorizedMerchants { get; set; }

    }
}