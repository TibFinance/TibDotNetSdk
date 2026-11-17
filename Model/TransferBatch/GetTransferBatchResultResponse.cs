
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.TransferBatch;
using Tib.Api.Common;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the GetTransferBatchResultResponse model.
    /// </summary>
    public class GetTransferBatchResultResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The request read; empty when the call is refused.
    /// </summary>
    public Guid? BatchId { get; set; }

    /// <summary>
    /// The request's merchant; empty when the call is refused.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The request's GroupId, as sent.
    /// </summary>
    public string GroupId { get; set; }

    /// <summary>
    /// Where the request stands; NotSet when the call is refused.
    /// </summary>
    public TransferBatchStatusEnum Status { get; set; }

    /// <summary>
    /// Why the request stopped: 2107 or 2110 when Status is Stopped, 2111 when it is Failed; 0 otherwise.
    /// </summary>
    public int BatchErrorCode { get; set; }

    /// <summary>
    /// A description of why the request stopped; empty unless Status is Stopped or Failed.
    /// </summary>
    public string BatchMessage { get; set; }

    /// <summary>
    /// When the request was accepted (UTC); empty when the call is refused.
    /// </summary>
    public DateTime? AcceptedDate { get; set; }

    /// <summary>
    /// When the processing of the request started (UTC); empty until then, and for a request whose items were all final in the reply.
    /// </summary>
    public DateTime? StartedDate { get; set; }

    /// <summary>
    /// When the request ended Completed, Stopped or Failed (UTC); empty until then.
    /// </summary>
    public DateTime? CompletedDate { get; set; }

    /// <summary>
    /// Counts and amounts over the whole request, whatever the page; AcceptedCount counts the items not processed yet.
    /// </summary>
    public TransferBatchTotalsModel Totals { get; set; }

    /// <summary>
    /// The page: the items whose Index is FromIndex or more, in index order, at most MaxItems of them.
    /// </summary>
    public List<TransferBatchItemResult> Results { get; set; }

    /// <summary>
    /// The Index to send as FromIndex for the next page; empty when this page reaches the request's last item.
    /// </summary>
    public int? NextIndex { get; set; }

    }
}