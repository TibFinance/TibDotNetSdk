
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the AddBankAccountArgs model.
    /// </summary>
    public class AddBankAccountArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The Merchant.Name shown on bank statements and used as the statement label. User-typed. Duplicates within the same client/service are permitted (pragmatic).
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// The merchant's primary contact email address.
    /// </summary>
    /// <value>A valid RFC 5322 email string, maximum 254 characters; may be null or omitted if no email is on record.</value>
    public string Email { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// The 3-digit bank/institution code (Canadian routing) identifying the financial institution — must be exactly 3 digits. Same field as AccountModel.BankNumber; the branch transit number is carried by InstitutionNumber.
    /// </summary>
    /// <value></value>
    public string BankNumber { get; set; }

    /// <summary>
    /// The 5-digit branch/transit number (Canadian routing) — must be exactly 5 digits. Despite the property name, this is the branch transit number, not the institution code (the institution is carried by BankNumber); the name is aligned with AccountModel.InstitutionNumber.
    /// </summary>
    /// <value></value>
    public string InstitutionNumber { get; set; }

    /// <summary>
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    }
}