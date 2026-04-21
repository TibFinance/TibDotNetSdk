
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the BillEntity model.
    /// </summary>
    public class BillEntity 
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// The title or description of the bill linked to the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may include alphanumeric characters, spaces, and common punctuation; optional and present only when the transfer is associated with a bill.</value>
    public string BillTitle { get; set; }

    /// <summary>
    /// The textual description of the bill associated with the transfer.
    /// </summary>
    /// <value>String, up to 255 characters; may be empty if no bill is linked. Returned as‑is from the originating system and used for display or reconciliation.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// The total monetary amount due for the requested bill.
    /// </summary>
    /// <value>Decimal value in the account's currency, non‑negative, typically with two decimal places of precision (e.g., 1234.56).</value>
    public decimal BillAmount { get; set; }

    /// <summary>
    /// The bill identifier assigned by the first external system linked to this transaction.
    /// </summary>
    /// <value>String, up to 50 characters, may be empty if no external system is associated; read‑only in responses.</value>
    public string ExternalSystemBillNumber1 { get; set; }

    /// <summary>
    /// Secondary bill identifier assigned by an external system
    /// </summary>
    /// <value>String, optional, up to 50 characters; read‑only in the response; may be null if not provided by the external system</value>
    public string ExternalSystemBillNumber2 { get; set; }

    /// <summary>
    /// The bill number assigned by the third external system.
    /// </summary>
    /// <value>String, up to 50 characters, may be null if not applicable; unique per external system bill.</value>
    public string ExternalSystemBillNumber3 { get; set; }

    /// <summary>
    /// The currency in which the bill amount is denominated.
    /// </summary>
    /// <value>Uses the CurrencyEnum (ISO 4217 codes). Must be one of the supported enum values; no conversion is performed on the returned value.</value>
    public CurrencyEnum? BillCurrency { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Identifier of the customer associated with the payment
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID that references an existing customer record in the system</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// Indicates whether the convenient fee rule is applied to the retrieved bill.
    /// </summary>
    /// <value>Boolean; true if the bill uses the convenient fee rule, false otherwise. Only relevant for bills that support fee rule customization; defaults to false when not applicable.</value>
    public bool UseConvenientFeeRule { get; set; }

    }
}