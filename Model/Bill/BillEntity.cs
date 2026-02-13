
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BillEntity 
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Represents the title of a bill associated with a payment.
    /// </summary>
    /// <value>This property holds the title of the bill. It is used to identify and describe the bill within the system.</value>
    public string BillTitle { get; set; }

    /// <summary>
    /// Provides a textual description of the bill associated with a payment.
    /// </summary>
    /// <value>A free‑form string that describes the purpose or details of the bill. The value is stored and returned as‑is.</value>
    public string BillDescription { get; set; }

    /// <summary>
    /// Specifies the monetary amount of a bill to be created.
    /// </summary>
    /// <value>Decimal value representing the total amount due for the bill. Must be greater than zero.</value>
    public decimal BillAmount { get; set; }

    /// <summary>
    /// Represents the first external system bill reference associated with the TIB bill.
    /// </summary>
    /// <value>ExternalSystemBillNumber1 contains the bill number provided by the external system. It is a free‑form string limited to 150 characters and restricted to the allowed character set.</value>
    public string ExternalSystemBillNumber1 { get; set; }

    /// <summary>
    /// Reference number provided by an external system for the bill (field 2).
    /// </summary>
    /// <value>Contains the external system's bill identifier (up to 150 characters) using only permitted characters.</value>
    public string ExternalSystemBillNumber2 { get; set; }

    /// <summary>
    /// Identifies the bill number provided by an external system. This field allows TIB to map its internal bill to the originating system's reference.
    /// </summary>
    /// <value>The third external system bill number associated with the created bill.</value>
    public string ExternalSystemBillNumber3 { get; set; }

    /// <summary>
    /// Specifies the currency of the bill. If null, the merchant’s default currency is applied.
    /// </summary>
    /// <value>CurrencyEnum value representing the bill’s currency.</value>
    public CurrencyEnum? BillCurrency { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Identifies the customer linked to this payment, when a customer relationship exists.
    /// </summary>
    /// <value>The unique GUID that references the associated customer record.</value>
    public Guid? RelatedCustomerId { get; set; }

    /// <summary>
    /// Indicates whether the bill should apply the convenience fee according to the client’s service configuration. The fee calculation follows the configuration set by an administrator.
    /// </summary>
    /// <value>true to enable convenience‑fee calculation for the bill; false to disable it.</value>
    public bool UseConvenientFeeRule { get; set; }

    }
}