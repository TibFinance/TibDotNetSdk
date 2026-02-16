
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the FreeOperationModel model.
    /// </summary>
    public class FreeOperationModel 
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid? BillId { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Retrieves or assigns the reference number associated with a transaction or operation.
    /// </summary>
    /// <value>Represents the unique identifier for tracking and referencing a specific transaction.</value>
    public string ReferenceNumber { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the due date for a transaction.
    /// </summary>
    /// <value>Specifies the date by which the transaction is expected to be completed.</value>
    public DateTime? TransactionDueDate { get; set; }

    /// <summary>
    /// Specifies the title or description of a transfer within the TIB Finance API.
    /// </summary>
    /// <value>The TransferTitle provides a brief, descriptive label for a transaction, aiding in identification and categorization.</value>
    public string TransferTitle { get; set; }

    /// <summary>
    /// Provides a textual representation of the transaction, detailing any errors encountered during processing.
    /// </summary>
    /// <value>This string contains a description of the transaction, including error codes for bank account payment methods, offering more detailed insights into transaction issues.</value>
    public string TransferDescription { get; set; }

    /// <summary>
    /// Represents the unique identifier for a transfer within an external system, facilitating tracking and integration.
    /// </summary>
    /// <value>This identifier is used to correlate and manage transactions between TIB Finance and external systems, ensuring seamless data exchange.</value>
    public string TransferExternalSystemNumber { get; set; }

    /// <summary>
    /// Defines the frequency at which transfers occur within the TIB Finance API.
    /// </summary>
    /// <value>This enumeration specifies the intervals for executing financial transfers, enabling precise scheduling and management of recurring transactions.</value>
    public TransferFrequencyEnum TransferFrequency { get; set; }

    /// <summary>
    /// Represents a brief description used in statements to identify or clarify the transaction.
    /// </summary>
    /// <value>This string provides a concise description for transactions, aiding in the identification and clarification of statement entries.</value>
    public string StatementDescription { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Indicates whether the transfer should be executed immediately within the TIB Finance API.
    /// </summary>
    /// <value>This boolean property determines if the transaction is processed instantly, bypassing any scheduled or delayed processing mechanisms.</value>
    public bool? ImmediateTransfer { get; set; }

    }
}