
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
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// This model encapsulates the details required to manage Interac payment methods for customers. It is used to facilitate electronic funds transfers via the Interac network, a widely used payment system in Canada.
    /// </summary>
    /// <value>The model does not directly return a value. It serves as a data structure to store and manage Interac payment information.</value>
    public InteracModel InteracInformation { get; set; }

    /// <summary>
    /// Indicates the direction of an Interac transaction.
    /// </summary>
    /// <value>Use 1 for Collect (merchant receives funds from the customer) or 2 for Deposit (merchant sends funds to the customer).</value>
    public TransferDirectionEnum TransferDirection { get; set; }

    /// <summary>
    /// Specifies the due date for the payment. If the value is null, the system treats the due date as the current date and time.
    /// </summary>
    /// <value>The date and time by which the payment must be completed.</value>
    public DateTime? DueDate { get; set; }

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