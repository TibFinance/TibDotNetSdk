
using System;
using Tib.Api.Financial;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateInteracPaymentMethodArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Determines if the customer's payment method is set as the default for automatic transactions.
    /// </summary>
    /// <value>This property returns a boolean value. It yields 'true' if the customer's payment method is configured for automatic transactions, and 'false' otherwise.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// This model encapsulates the details required to manage Interac payment methods for customers. It is used to facilitate electronic funds transfers via the Interac network, a widely used payment system in Canada.
    /// </summary>
    /// <value>The model does not directly return a value. It serves as a data structure to store and manage Interac payment information.</value>
    public InteracModel InteracInformation { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}