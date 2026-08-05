
using System;
using System.Collections.Generic;
using Tib.Api.Model.FreeOperation;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the CreateFreeOperationBatchResponse model.
    /// </summary>
    public class CreateFreeOperationBatchResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of individual batch item results.
    /// </summary>
    public List<CreateFreeOperationBatchResponseBase> CreateFreeOperationBatchResponses { get; set; }

    }
}