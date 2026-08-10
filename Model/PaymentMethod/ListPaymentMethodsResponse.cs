
using System;
using System.Collections.Generic;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the ListPaymentMethodsResponse model.
    /// </summary>
    public class ListPaymentMethodsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of customer payment method
    /// </summary>
    /// <value>The payment methods.</value>
    public IEnumerable<PaymentMethodModel> PaymentMethods { get; set; }

    }
}