
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetDependentOperationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifies the specific transfer operation that needs to be reverted.
    /// </summary>
    /// <value>This identifier is used to specify which failed transfer operation should be targeted for a retry process.</value>
    public Guid TransferId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    }
}