
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.TransferBatch;
using Tib.Api.Common;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the CreateTransferBatchResponse model.
    /// </summary>
    public class CreateTransferBatchResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The request's id, to read its outcome with GetTransferBatchResult: set when BatchOutcome is Accepted or Processed, and when the call is refused with 2101, where it names the earlier request that used the IdempotencyKey; empty otherwise.
    /// </summary>
    public Guid? BatchId { get; set; }

    /// <summary>
    /// Accepted when at least one item is Accepted: those items are processed in the background (read their outcome with GetTransferBatchResult); Processed when every item's outcome is final in this reply; Refused when the call was refused as a whole and nothing was accepted; Validated for a ValidateOnly call.
    /// </summary>
    public TransferBatchOutcomeEnum BatchOutcome { get; set; }

    /// <summary>
    /// Why the call was refused; 0 unless BatchOutcome is Refused.
    /// </summary>
    public int BatchErrorCode { get; set; }

    /// <summary>
    /// A description of why the call was refused; empty unless BatchOutcome is Refused.
    /// </summary>
    public string BatchMessage { get; set; }

    /// <summary>
    /// Counts and amounts for the items of this call. Nothing is created while the call runs: CreatedCount, NotProcessedCount and the amounts are 0, and AcceptedCount counts the items to be processed in the background.
    /// </summary>
    public TransferBatchTotalsModel Totals { get; set; }

    /// <summary>
    /// One result per item, in request order.
    /// </summary>
    public List<TransferBatchItemResult> Results { get; set; }

    }
}