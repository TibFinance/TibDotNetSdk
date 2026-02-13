
using System;
using Tib.Api.Model.FreeOperation;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BatchFileEventToBroadcast 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public FreeOperationModel FreeOperation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string File { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid? PaymentId { get; set; }

    }
}