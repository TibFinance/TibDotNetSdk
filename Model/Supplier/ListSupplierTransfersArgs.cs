
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierTransfersArgs model.
    /// </summary>
    public class ListSupplierTransfersArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Start of the date range filter, UTC (inclusive). Defaults to 3 months ago if not specified.
    /// </summary>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// End of the date range filter, UTC (exclusive). Defaults to now if not specified.
    /// </summary>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// When true, the request returns only transfers that have errors.
    /// </summary>
    /// <value>Optional boolean; defaults to false (returns all transfers). Must be a valid JSON boolean.</value>
    public bool OnlyWithErrors { get; set; }

    /// <summary>
    /// Indicates whether to return only transfers that have been resolved
    /// </summary>
    /// <value>Boolean flag; true filters the list to resolved transfers only, false (or omitted) returns all transfers. Must be a valid bool value.</value>
    public bool MarkResolvedOnly { get; set; }

    /// <summary>
    /// Identifier of the transfer group to filter the listed transfers
    /// </summary>
    /// <value>String, non‑empty, case‑sensitive; must match an existing TransferGroupId (e.g., UUID or alphanumeric up to 64 characters).</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Optional filter to show only transfers for a specific supplier. When set, filters by Transfer.RelatedMerchantId == SupplierMerchantId.
    /// </summary>
    public Guid? SupplierMerchantId { get; set; }

    }
}