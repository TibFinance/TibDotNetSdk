
using System;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the TransferBatchTotalsModel model.
    /// </summary>
    public class TransferBatchTotalsModel 
    {
        
    /// <summary>
    /// Number of items in the request.
    /// </summary>
    public int ItemCount { get; set; }

    /// <summary>
    /// Items whose payment was created; always 0 in the CreateTransferBatch reply.
    /// </summary>
    public int CreatedCount { get; set; }

    /// <summary>
    /// Items that matched an existing payment.
    /// </summary>
    public int AlreadyCreatedCount { get; set; }

    /// <summary>
    /// Items that were refused.
    /// </summary>
    public int RefusedCount { get; set; }

    /// <summary>
    /// Items that were not processed: processing stopped before their payment was created, or the request stopped before them; always 0 in the CreateTransferBatch reply.
    /// </summary>
    public int NotProcessedCount { get; set; }

    /// <summary>
    /// Items that passed every check and are not processed yet: in the reply, the items to be processed in the background; in GetTransferBatchResult, those still waiting.
    /// </summary>
    public int AcceptedCount { get; set; }

    /// <summary>
    /// Total amount of the collections the request created; always 0 in the CreateTransferBatch reply.
    /// </summary>
    public decimal CreatedCollectionAmount { get; set; }

    /// <summary>
    /// Total amount of the deposits the request created; always 0 in the CreateTransferBatch reply.
    /// </summary>
    public decimal CreatedDepositAmount { get; set; }

    }
}