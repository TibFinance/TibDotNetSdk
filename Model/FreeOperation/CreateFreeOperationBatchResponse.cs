
using System;
using System.Collections.Generic;
using Tib.Api.Model.FreeOperation;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateFreeOperationBatchResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents a collection of responses for a batch of free operations, facilitating transactions not associated with specific bills.
    /// </summary>
    /// <value>This model is used to handle the responses from creating multiple free operations in a single batch, optimizing the process of managing transactions that are independent of bills.</value>
    public List<CreateFreeOperationBatchResponseBase> CreateFreeOperationBatchResponses { get; set; }

    }
}