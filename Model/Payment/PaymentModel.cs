
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Model.Payment;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PaymentModel : PaymentBaseWithHierarchyModel
    {
        
    /// <summary>
    /// Gets or sets the collection of payment operations associated with the current entity.
    /// </summary>
    /// <value>A list of PaymentOperationEntity objects representing each operation performed on the payment.</value>
    public List<PaymentOperationEntity> Operations { get; set; }

    }
}