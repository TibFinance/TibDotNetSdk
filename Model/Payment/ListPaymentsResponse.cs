
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListPaymentsResponse model.
    /// </summary>
    public class ListPaymentsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves the collection of PaymentModel objects that satisfy the current query criteria.
    /// </summary>
    /// <value>An IEnumerable containing the matching payments.</value>
    public IEnumerable<PaymentModel> Payments { get; set; }

    }
}