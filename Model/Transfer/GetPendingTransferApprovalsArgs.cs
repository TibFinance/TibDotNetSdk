
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Transfer
{
    /// <summary>
    /// Represents the GetPendingTransferApprovalsArgs model.
    /// </summary>
    public class GetPendingTransferApprovalsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Optional. Limits the list to one of your services. When it is not sent, the list covers all your services. A service that does not exist or is not yours gives an empty list, not an error.
    /// </summary>
    public Guid? ServiceId { get; set; }

    }
}