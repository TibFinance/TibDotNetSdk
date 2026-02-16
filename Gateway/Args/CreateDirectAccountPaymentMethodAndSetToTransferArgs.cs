
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the CreateDirectAccountPaymentMethodAndSetToTransferArgs model.
    /// </summary>
    public class CreateDirectAccountPaymentMethodAndSetToTransferArgs : BaseCreateDirectAccountPaymentMethod
    {
        
    /// <summary>
    /// Indicates if the system must request the customer's consent prior to executing the payment.
    /// </summary>
    /// <value>Set to true to trigger a consent request; false skips the consent step.</value>
    public bool? AskForCustomerConsent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PublicAccessTokenRoutingType? RoutingType { get; set; }

    }
}