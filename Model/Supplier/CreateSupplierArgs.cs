
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the CreateSupplierArgs model.
    /// </summary>
    public class CreateSupplierArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Display name for the supplier (max 150 characters).
    /// </summary>
    /// <value></value>
    public string SupplierName { get; set; }

    /// <summary>
    /// Email address of the supplier. Used for deduplication and login creation (max 250 characters).
    /// </summary>
    /// <value></value>
    public string SupplierEmail { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// The bank's identification number used for the direct account payment method.
    /// </summary>
    /// <value>String of up to 4 numeric characters, required, no spaces or special symbols.</value>
    public string BankNumber { get; set; }

    /// <summary>
    /// The bank's institution number identifying the financial institution for the direct account payment.
    /// </summary>
    /// <value>String of exactly 3 numeric characters (e.g., "001"); required; must correspond to a valid institution in the TIB Finance network.</value>
    public string InstitutionNumber { get; set; }

    }
}