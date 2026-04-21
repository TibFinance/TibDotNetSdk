
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the CreateCreditCardPaymentMethodAndSetToTransferArgs model.
    /// </summary>
    public class CreateCreditCardPaymentMethodAndSetToTransferArgs : BaseCreateCreditCardPaymentMethodArgs
    {
        
    /// <summary>
    /// Indicates whether the platform must request the customer's consent before processing the payment.
    /// </summary>
    /// <value>Boolean; set to true to trigger a consent prompt (required for regulated or high‑value payments). Defaults to false if omitted.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType? RoutingType { get; set; }

    }
}