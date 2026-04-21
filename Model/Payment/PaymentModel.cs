
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Model.Payment;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the PaymentModel model.
    /// </summary>
    public class PaymentModel : PaymentBaseWithHierarchyModel
    {
        
    /// <summary>
    /// A collection of payment operations included in the ListTransfers response
    /// </summary>
    /// <value>List of PaymentOperationEntity objects, each describing a single transfer (id, amount, currency, status, timestamps, etc.). May be empty; order follows the request's sorting criteria. Read‑only and limited to the page size defined by pagination parameters.</value>
    public List<PaymentOperationEntity> Operations { get; set; }

    }
}