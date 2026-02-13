
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AccountModel 
    {
        
    /// <summary>
    /// Represents the name associated with the merchant's account.
    /// </summary>
    /// <value>Specifies the name of the merchant's account used for identification and transaction purposes.</value>
    public string AccountName { get; set; }

    /// <summary>
    /// The 'Owner' property is designed to assign and identify the ownership of a specific resource or object within the system.
    /// </summary>
    /// <value>The 'Owner' property holds a unique string value that signifies the identifier of the owner, ensuring distinct representation within the system.</value>
    public string Owner { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string FirstName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string LastName { get; set; }

    /// <summary>
    /// Specifies the payment method type associated with the account.
    /// </summary>
    /// <value>Indicates whether the account is a Credit Card, Bank Account, or Interac payment method.</value>
    public AccountTypeEnum? AccountType { get; set; }

    /// <summary>
    /// Identifies the bank associated with the account using its numeric identifier.
    /// </summary>
    /// <value>Holds the bank number as a string. The value must not exceed the allowed length.</value>
    public string BankNumber { get; set; }

    /// <summary>
    /// Bank institution code identifying the financial institution for a transaction.
    /// </summary>
    /// <value>The institution number as a string. It uniquely identifies the bank within the TIB Finance network and is required when specifying a merchant bank account.</value>
    public string InstitutionNumber { get; set; }

    /// <summary>
    /// Specifies the bank account number associated with the payment method.
    /// </summary>
    /// <value>Gets or sets the account number. The value must be a non‑empty string with a maximum length of 20 characters.</value>
    public string AccountNumber { get; set; }

    /// <summary>
    /// The routing number identifying the bank where the customer's account is held.
    /// </summary>
    /// <value>A string of exactly nine numeric characters representing the institution's routing number.</value>
    public string RoutingNumber { get; set; }

    /// <summary>
    /// Some bank as check digit
    /// </summary>
    /// <value>The check digit.</value>
    public string CheckDigit { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum? Currency { get; set; }

    /// <summary>
    /// Full account number
    /// </summary>
    /// <value>The full account number.</value>
    public string FullAccountNumber { get; set; }

    /// <summary>
    /// Gets the account number with check digit.
    /// </summary>
    /// <value>The account number with check digit.</value>
    public string AccountNumberWithCheckDigit { get; set; }

    /// <summary>
    /// Obfuscated string of the account
    /// </summary>
    /// <value>The preview string.</value>
    public string PreviewString { get; set; }

    }
}