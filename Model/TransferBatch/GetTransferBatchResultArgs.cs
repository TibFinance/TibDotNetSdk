
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the GetTransferBatchResultArgs model.
    /// </summary>
    public class GetTransferBatchResultArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Required: the BatchId of a CreateTransferBatch reply.
    /// </summary>
    public Guid BatchId { get; set; }

    /// <summary>
    /// The Index of the first item of the page, 0 to 4,999; 0 when empty. Send 0 first, then each page's NextIndex, which is the previous FromIndex plus the number of items returned (1,000, 2,000 and so on with the default MaxItems), until NextIndex is empty.
    /// </summary>
    public int? FromIndex { get; set; }

    /// <summary>
    /// The most items the page holds, 0 to 1,000; 1,000 when empty. 0 returns the request's state and totals only.
    /// </summary>
    public int? MaxItems { get; set; }

    }
}