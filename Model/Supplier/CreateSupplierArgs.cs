
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
    public string SupplierName { get; set; }

    /// <summary>
    /// Email address of the supplier. Used for deduplication and login creation (max 250 characters).
    /// </summary>
    public string SupplierEmail { get; set; }

    /// <summary>
    /// Currency for the supplier's account (1 = CAD, 2 = USD).
    /// </summary>
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
    /// Supplier's bank/institution code (Canadian routing) — the 3-digit code identifying the financial institution where the account is held. This is the bank itself, not the branch — the branch transit number is carried by InstitutionNumber.
    /// </summary>
    public string BankNumber { get; set; }

    /// <summary>
    /// Supplier's 5-digit branch/transit number (Canadian routing). Despite the property name, this is the branch transit number, not the institution code — the institution is carried by BankNumber.
    /// </summary>
    public string InstitutionNumber { get; set; }

    }
}