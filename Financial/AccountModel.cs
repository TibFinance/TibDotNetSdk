
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
    public string Owner { get; set; }

    /// <summary>
    /// The bank/institution code (Canadian routing) identifying the financial institution where the account is held — normally 3 digits, though accounts imported from CPA-format routing strings carry it zero-padded to 4 (0III). This is the bank itself, not the branch — the branch transit number is carried by InstitutionNumber.
    /// </summary>
    public string BankNumber { get; set; }

    /// <summary>
    /// The 5-digit branch/transit number (Canadian routing) where the account is held. Despite the property name, this is the branch transit number, not the institution code — the institution is carried by BankNumber.
    /// </summary>
    public string InstitutionNumber { get; set; }

    /// <summary>
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// Convenience alias for the Canadian routing pair. On read, returns BankNumber concatenated with InstitutionNumber. On write, accepts exactly 9 digits — a 4-digit zero-padded institution code followed by a 5-digit branch transit — and splits them into BankNumber and InstitutionNumber; a value of any other length is ignored silently. Supply either this field or BankNumber + InstitutionNumber.
    /// </summary>
    public string RoutingNumber { get; set; }

    /// <summary>
    /// The check digit used to validate the account number in the direct account payment method.
    /// </summary>
    /// <value>String of numeric characters (typically 1‑2 digits) calculated per the bank's algorithm; must match the account number's computed check digit.</value>
    public string CheckDigit { get; set; }

    /// <summary>
    /// The currency denomination of the account (e.g., CAD, USD).
    /// </summary>
    public CurrencyEnum? Currency { get; set; }

    }
}