
using System;
using Tib.Api.Financial;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the BaseCreateDirectAccountPaymentMethod model.
    /// </summary>
    public class BaseCreateDirectAccountPaymentMethod : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Determines if the customer's payment method is set as the default for automatic transactions.
    /// </summary>
    /// <value>This property returns a boolean value. It yields 'true' if the customer's payment method is configured for automatic transactions, and 'false' otherwise.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Token { get; set; }

    /// <summary>
    /// Contains the necessary details for replacing a merchant's account information within the system.
    /// </summary>
    /// <value>This model represents the account details associated with a merchant, ensuring that all relevant information is accurately captured and stored.</value>
    public AccountModel Account { get; set; }

    }
}