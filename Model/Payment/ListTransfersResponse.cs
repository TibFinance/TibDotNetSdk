
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves the collection of PaymentModel objects that satisfy the current query criteria.
    /// </summary>
    /// <value>An IEnumerable containing the matching payments.</value>
    public IEnumerable<PaymentModel> Payments { get; set; }

    }
}