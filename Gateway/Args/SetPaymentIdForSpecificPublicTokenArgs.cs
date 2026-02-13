
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SetPaymentIdForSpecificPublicTokenArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Indicates if the system must request the customer's consent prior to executing the payment.
    /// </summary>
    /// <value>Set to true to trigger a consent request; false skips the consent step.</value>
    public bool? AskForCustomerConsent { get; set; }

    }
}