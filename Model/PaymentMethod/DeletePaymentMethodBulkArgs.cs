
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeletePaymentMethodBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> PaymentMethodIds { get; set; }

    }
}