
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the AccountModel model.
    /// </summary>
    public class AccountModel 
    {
        
    /// <summary>
    /// The display name of the account involved in the transfer.
    /// </summary>
    /// <value>String (max 100 chars); reflects the account's configured name, may include alphanumeric characters and spaces.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// The full name of the account holder, as registered with the financial institution.
    /// </summary>
    /// <value></value>
    public string Owner { get; set; }

    /// <summary>
    /// The payer's given name for the direct account payment.
    /// </summary>
    /// <value>Required string, up to 50 characters, alphabetic characters only (no digits or special symbols).</value>
    public string FirstName { get; set; }

    /// <summary>
    /// The account holder’s last name for the direct account payment method.
    /// </summary>
    /// <value>Required string, up to 50 characters, alphabetic characters and common punctuation (e.g., hyphen, apostrophe) only.</value>
    public string LastName { get; set; }

    /// <summary>
    /// BlueSnap ECP (ACH) account type chosen client-side. Optional, max 40 characters, with no server-side whitelist; TIB's own interfaces send CONSUMER_CHECKING (the default), CONSUMER_SAVINGS, CORPORATE_CHECKING or CORPORATE_SAVINGS. Any value starting with CORPORATE (case-insensitive) makes the server derive the provider-required company name for Corporate eCheck from the account Owner. Not sent to the provider directly.
    /// </summary>
    /// <value></value>
    public string EcpAccountType { get; set; }

    /// <summary>
    /// The type of bank account (e.g., personal checking, corporate savings).
    /// </summary>
    /// <value></value>
    public AccountTypeEnum? AccountType { get; set; }

    /// <summary>
    /// The bank/institution code (Canadian routing) identifying the financial institution where the account is held — normally 3 digits, though accounts imported from CPA-format routing strings carry it zero-padded to 4 (0III). This is the bank itself, not the branch — the branch transit number is carried by InstitutionNumber.
    /// </summary>
    /// <value></value>
    public string BankNumber { get; set; }

    /// <summary>
    /// The 5-digit branch/transit number (Canadian routing) where the account is held. Despite the property name, this is the branch transit number, not the institution code — the institution is carried by BankNumber.
    /// </summary>
    /// <value></value>
    public string InstitutionNumber { get; set; }

    /// <summary>
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// The combined routing number (bank number + institution number), used to identify the specific branch.
    /// </summary>
    /// <value></value>
    public string RoutingNumber { get; set; }

    /// <summary>
    /// The check digit used to validate the account number in the direct account payment method.
    /// </summary>
    /// <value>String of numeric characters (typically 1‑2 digits) calculated per the bank's algorithm; must match the account number's computed check digit.</value>
    public string CheckDigit { get; set; }

    /// <summary>
    /// The currency denomination of the account (e.g., CAD, USD).
    /// </summary>
    /// <value></value>
    public CurrencyEnum? Currency { get; set; }

    /// <summary>
    /// The complete account number string composed of bank number, institution number, account number, and optional check digit, separated by dashes.
    /// </summary>
    /// <value></value>
    public string FullAccountNumber { get; set; }

    /// <summary>
    /// The account number appended with the check digit (if present), separated by a dash.
    /// </summary>
    /// <value></value>
    public string AccountNumberWithCheckDigit { get; set; }

    /// <summary>
    /// A formatted string that previews the direct account payment method details before creation.
    /// </summary>
    /// <value>Must be a non‑empty UTF‑8 string, max 256 characters; includes masked account number, bank name, and optional reference, following the platform’s preview template.</value>
    public string PreviewString { get; set; }

    }
}