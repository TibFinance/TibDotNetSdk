
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RequestDataResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid? PaymentMethodId { get; set; }

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
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the due date for a transaction.
    /// </summary>
    /// <value>Specifies the date by which the transaction is expected to be completed.</value>
    public DateTime? TransactionDueDate { get; set; }

    }
}