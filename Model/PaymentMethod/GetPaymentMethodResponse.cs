
using System;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the GetPaymentMethodResponse model.
    /// </summary>
    public class GetPaymentMethodResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The payment method returned by the GetPaymentMethod request.
    /// </summary>
    /// <value>An object of type PaymentMethodModel containing the method's unique identifier, display name, supported currency codes, activation status, and any additional configuration flags. This field is always present in the response and is read‑only.</value>
    public PaymentMethodModel PaymentMethod { get; set; }

    }
}