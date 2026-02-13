
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class EditAuthorizationStatusBulkArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> PaymentIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public TibAuthorizationStatus AuthorizationStatus { get; set; }

    }
}