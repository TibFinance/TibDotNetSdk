
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the SetPaymentIdForSpecificPublicTokenArgs model.
    /// </summary>
    public class SetPaymentIdForSpecificPublicTokenArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Identifier of the payment method to be set as the default for the account
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID referencing an existing, active payment method owned by the caller; cannot be null or belong to another tenant.</value>
    public Guid PaymentMethodId { get; set; }

    /// <summary>
    /// Indicates whether the platform must request the customer's consent before processing the payment.
    /// </summary>
    /// <value>Boolean; set to true to trigger a consent prompt (required for regulated or high‑value payments). Defaults to false if omitted.</value>
    public bool? AskForCustomerConsent { get; set; }

    }
}