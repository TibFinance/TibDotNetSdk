
using System;
using System.Collections.Generic;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BatchFileEventPayload : BaseEventPayload
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string File { get; set; }

    /// <summary>
    /// Gets or sets the collection of payment operations associated with the current entity.
    /// </summary>
    /// <value>A list of PaymentOperationEntity objects representing each operation performed on the payment.</value>
    public List<BatchFileEventOperation> Operations { get; set; }

    }
}