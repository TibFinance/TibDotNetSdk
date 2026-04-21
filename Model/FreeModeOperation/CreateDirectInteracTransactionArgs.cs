
using System;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the CreateDirectInteracTransactionArgs model.
    /// </summary>
    public class CreateDirectInteracTransactionArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// Details of the Interac e‑transfer payment method to be created.
    /// </summary>
    /// <value>Required InteracModel containing valid Canadian banking fields (bankAccountNumber, transitNumber, institutionNumber) and optional description; all values must conform to Canadian banking format and the object cannot be null.</value>
    public InteracModel InteracInformation { get; set; }

    /// <summary>
    /// This property determine if you desire to deposit money to someone account of if you request someone to pay the merchant using Interac.
    /// </summary>
    /// <value></value>
    public TransferDirectionEnum TransferDirection { get; set; }

    /// <summary>
    /// The date by which the created payment must be settled.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be a future date, not earlier than the current date, and cannot exceed the platform's maximum scheduling horizon.</value>
    public DateTime? DueDate { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// The text that will appear on the payer’s bank statement for this payment.
    /// </summary>
    /// <value>String, up to 140 characters; may include alphanumeric characters and basic punctuation; trimmed of leading/trailing whitespace; must not contain line breaks or special symbols that banks reject.</value>
    public string StatementDescription { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum? Currency { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Use this property to match transaction in other system.
    /// </summary>
    /// <value></value>
    public string ReferenceNumber { get; set; }

    }
}