
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the BaseCreateCreditCardPaymentMethodArgs model.
    /// </summary>
    public class BaseCreateCreditCardPaymentMethodArgs : BaseAuthenticatePublicTokenArgs
    {
        
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

    }
}