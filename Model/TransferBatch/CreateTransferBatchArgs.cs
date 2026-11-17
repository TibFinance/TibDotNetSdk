
using System;
using System.Collections.Generic;
using Tib.Api.Model.TransferBatch;
using Tib.Api.Common;

namespace Tib.Api.Model.TransferBatch
{
    /// <summary>
    /// Represents the CreateTransferBatchArgs model.
    /// </summary>
    public class CreateTransferBatchArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The merchant the items belong to. Required for a client or service session; a merchant session may leave it empty, or send its own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Optional label, up to 50 characters, stored on every payment the request creates. It is not used to detect duplicates.
    /// </summary>
    public string GroupId { get; set; }

    /// <summary>
    /// When true, every item is checked but nothing is created. Send the real call with a new IdempotencyKey.
    /// </summary>
    public bool ValidateOnly { get; set; }

    /// <summary>
    /// Required: the payments to create, 1 to 5,000, processed in this order.
    /// </summary>
    public List<TransferBatchItemModel> Items { get; set; }

    }
}