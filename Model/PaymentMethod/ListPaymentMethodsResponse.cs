
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
    /// This function is engineered to retrieve or allocate the array of accessible payment methods for transactional operations.
    /// </summary>
    /// <value>The function generates an exhaustive list of models that represent diverse payment methods.</value>
    public IEnumerable<PaymentMethodModel> PaymentMethods { get; set; }

    }
}