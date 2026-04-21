
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
    /// Identifier of the entity that owns the payment method.
    /// </summary>
    /// <value>String, non‑empty, typically a UUID or account ID representing the user or merchant; immutable for the lifetime of the method.</value>
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
    /// The type of payment method used for the transfer.
    /// </summary>
    /// <value>Enum PaymentMethodTypeEnum (e.g., BANK_ACCOUNT, CREDIT_CARD, DEBIT_CARD, WALLET). Always present in the response; reflects the source or destination account category.</value>
    public AccountTypeEnum? AccountType { get; set; }

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

    /// <summary>
    /// The bank account number used for the direct account payment.
    /// </summary>
    /// <value>String of digits only (no spaces or symbols), typically 8–34 characters, matching the format required by the selected bank; required input.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// The bank routing number identifying the financial institution for the direct account payment.
    /// </summary>
    /// <value>String of exactly 9 numeric digits (e.g., "021000021"); no spaces or symbols; required for ACH transfers.</value>
    public string RoutingNumber { get; set; }

    /// <summary>
    /// The check digit used to validate the account number in the direct account payment method.
    /// </summary>
    /// <value>String of numeric characters (typically 1‑2 digits) calculated per the bank's algorithm; must match the account number's computed check digit.</value>
    public string CheckDigit { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum? Currency { get; set; }

    /// <summary>
    /// The complete bank account number to be used for the direct payment method.
    /// </summary>
    /// <value>String of digits only, no spaces or delimiters; length typically 8‑34 characters; may include leading zeros; must pass checksum validation (e.g., MOD‑97) and correspond to the specified bank and branch.</value>
    public string FullAccountNumber { get; set; }

    /// <summary>
    /// The full bank account number including its check digit.
    /// </summary>
    /// <value>String of digits only; length varies by institution (typically 9‑12 characters). Must match the account's official format and include the final check digit for validation.</value>
    public string AccountNumberWithCheckDigit { get; set; }

    /// <summary>
    /// A formatted string that previews the direct account payment method details before creation.
    /// </summary>
    /// <value>Must be a non‑empty UTF‑8 string, max 256 characters; includes masked account number, bank name, and optional reference, following the platform’s preview template.</value>
    public string PreviewString { get; set; }

    }
}