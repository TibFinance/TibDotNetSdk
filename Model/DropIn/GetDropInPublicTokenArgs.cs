
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.DropIn
{
    /// <summary>
    /// Represents the GetDropInPublicTokenArgs model.
    /// </summary>
    public class GetDropInPublicTokenArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid? CustomerId { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a bill.
    /// </summary>
    /// <value>Represents the unique identifier associated with a bill.</value>
    public Guid? BillId { get; set; }

    /// <summary>
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public Decimal Amount { get; set; }

    /// <summary>
    /// Defines and manages the type of transfer operation within the system.
    /// </summary>
    /// <value>Specifies the category of the transfer, determining its processing logic and applicable rules.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Specifies the payment method flags that are authorized for the Drop‑In session.
    /// </summary>
    /// <value>Flags indicating which payment methods the Drop‑In UI may present to the customer.</value>
    public AutorizedPaymentMethodFlags DropInAuthorizedPaymentMethod { get; set; }

    /// <summary>
    /// Gets or sets the external reference number used to link this entity with an external system or business process.
    /// </summary>
    /// <value>The external reference number associated with the entity.</value>
    public string ExternalReferenceNumber { get; set; }

    /// <summary>
    /// Specifies whether the API request should include the customer's existing payment methods in the response.
    /// </summary>
    /// <value>True to include the customer's existing payment methods; false to exclude them.</value>
    public bool ShowCustomerExistingPaymentMethods { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Specifies the lifetime of the public token in days.
    /// </summary>
    /// <value>An integer representing how many days the token remains valid after issuance.</value>
    public int ExpirationDays { get; set; }

    /// <summary>
    /// Gets or sets the title that identifies the object in a human‑readable way.
    /// </summary>
    /// <value>A short, descriptive string displayed in user interfaces and reports.</value>
    public string Title { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the due date for a payment.
    /// </summary>
    /// <value>The date and time when the payment must be completed, expressed in UTC.</value>
    public DateTime? PaymentDueDate { get; set; }

    }
}