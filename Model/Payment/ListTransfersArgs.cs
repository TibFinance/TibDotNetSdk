
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersArgs model.
    /// </summary>
    public class ListTransfersArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Specifies the granularity of payment filtering applied when listing transfers
    /// </summary>
    /// <value>Accepts a PaymentFilterLevelEnum value (e.g., NONE, ACCOUNT, TRANSACTION). Determines which payments are included based on the selected level; defaults to NONE if omitted. Must match one of the enum members; otherwise the request is rejected.</value>
    public PaymentFilterLevelEnum? PaymentFilterLevel { get; set; }

    /// <summary>
    /// Identifier of the level filter to apply when listing transfers
    /// </summary>
    /// <value>Guid representing a specific LevelFilter; must be a valid UUID. If omitted or empty, no level‑based filtering is applied.</value>
    public Guid? LevelFilterId { get; set; }

    /// <summary>
    /// If true, the request returns only transfers that are marked as resolved.
    /// </summary>
    /// <value>Boolean input; default false. When set to true, unresolved transfers are excluded from the result set. No other status filters may be applied concurrently.</value>
    public bool MarkResolvedOnly { get; set; }

    /// <summary>
    /// The start date-time for the transfer search window.
    /// </summary>
    /// <value>ISO‑8601 DateTime (UTC). Must be earlier than or equal to ToDate and cannot be set in the future.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Upper bound of the transfer creation date range for the query
    /// </summary>
    /// <value>ISO‑8601 UTC DateTime; inclusive; must be ≥ FromDate; cannot exceed current server time; typical max range 90 days</value>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Identifier of the transfer group to filter the fast transfer list
    /// </summary>
    /// <value>String, required; must be a valid UUID (36 characters, hyphenated) representing an existing TransferGroupId</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeFlag TransferType { get; set; }

    /// <summary>
    /// Identifier of the external merchant group for which transfers are requested
    /// </summary>
    /// <value>String, required; must match the external system's merchant group ID format (e.g., alphanumeric, up to 64 characters).</value>
    public string ExternalMerchantGroupId { get; set; }

    /// <summary>
    /// When true, ListTransfersFast returns only transfers that have errors.
    /// </summary>
    /// <value>Boolean input; defaults to false (returns all transfers). Ignored if omitted. Must be true or false.</value>
    public bool OnlyWithErrors { get; set; }

    }
}