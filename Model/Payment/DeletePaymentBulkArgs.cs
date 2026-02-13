
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeletePaymentBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> PaymentIds { get; set; }

    }
}