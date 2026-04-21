
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
    /// Indicates whether this payment method is configured as the customer's automatic payment method.
    /// </summary>
    /// <value>True if the method will be used for automatic payments, false otherwise. Only applicable to payment methods that support auto‑pay; the flag is read‑only in this response.</value>
    public bool IsCustomerAutomaticPaymentMethod { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Token { get; set; }

    /// <summary>
    /// The target bank account for the direct payment.
    /// </summary>
    /// <value>Must be a valid, active AccountModel (e.g., accountNumber, routingNumber) belonging to the payer; cannot be null.</value>
    public AccountModel Account { get; set; }

    }
}