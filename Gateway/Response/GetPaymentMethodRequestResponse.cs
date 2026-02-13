
using System;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPaymentMethodRequestResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the payment method request data.
    /// </summary>
    /// <value>The payment method request data.</value>
    public PaymentMethodAddRequestModel PaymentMethodRequestData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}