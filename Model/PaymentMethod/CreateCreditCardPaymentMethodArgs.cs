
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateCreditCardPaymentMethodArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

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
    /// Manages all operations associated with credit card data.
    /// </summary>
    /// <value>Represents a distinct numerical identifier that corresponds to a specific credit card in the system.</value>
    public CreditCardModel CreditCard { get; set; }

    /// <summary>
    /// Specifies the name of the card owner.
    /// </summary>
    /// <value>Represents the name of the individual who owns the credit card. This information is crucial for validating and processing transactions.</value>
    public string CardOwner { get; set; }

    /// <summary>
    /// For ZipCode only situation, not full address
    /// </summary>
    /// <value></value>
    public string ZipCode { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum? Language { get; set; }

    }
}