
using System;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateDirectDepositArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the origin merchant identifier.
    /// </summary>
    /// <value>The origin merchant identifier.</value>
    public Guid OriginMerchantId { get; set; }

    /// <summary>
    /// Free deposit account information
    /// </summary>
    /// <value>The destination account.</value>
    public AccountModel DestinationAccount { get; set; }

    /// <summary>
    /// Gets or sets the deposit due date.
    /// </summary>
    /// <value>The deposit due date.</value>
    public DateTime? DepositDueDate { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Represents a brief description used in statements to identify or clarify the transaction.
    /// </summary>
    /// <value>This string provides a concise description for transactions, aiding in the identification and clarification of statement entries.</value>
    public string StatementDescription { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum? Currency { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the reference number associated with a transaction or operation.
    /// </summary>
    /// <value>Represents the unique identifier for tracking and referencing a specific transaction.</value>
    public string ReferenceNumber { get; set; }

    }
}