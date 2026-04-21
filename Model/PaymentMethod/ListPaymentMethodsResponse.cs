
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
    /// A collection of payment methods available to the requester.
    /// </summary>
    /// <value>IEnumerable of PaymentMethodModel objects; each includes identifiers, display name, and type. May be empty if no methods are configured. Order is not guaranteed.</value>
    public IEnumerable<PaymentMethodModel> PaymentMethods { get; set; }

    }
}