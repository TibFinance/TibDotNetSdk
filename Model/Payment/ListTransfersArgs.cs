
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
    /// Indicates whether to return only transfers that have been resolved
    /// </summary>
    /// <value>Boolean flag; true filters the list to resolved transfers only, false (or omitted) returns all transfers. Must be a valid bool value.</value>
    public bool MarkResolvedOnly { get; set; }

    /// <summary>
    /// Start of the payment-due-date range filter, UTC (inclusive). Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>From date.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// End of the payment-due-date range filter, UTC (inclusive). Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>To date.</value>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Identifier of the transfer group to filter the listed transfers
    /// </summary>
    /// <value>String, non‑empty, case‑sensitive; must match an existing TransferGroupId (e.g., UUID or alphanumeric up to 64 characters).</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeFlag TransferType { get; set; }

    /// <summary>
    /// Identifier of the external merchant group for which transfers are being listed
    /// </summary>
    /// <value>String, case‑sensitive, alphanumeric (may include hyphens/underscores), up to 50 characters; must correspond to an existing ExternalMerchantGroup in the system</value>
    public string ExternalMerchantGroupId { get; set; }

    /// <summary>
    /// When true, the request returns only transfers that have errors.
    /// </summary>
    /// <value>Optional boolean; defaults to false (returns all transfers). Must be a valid JSON boolean.</value>
    public bool OnlyWithErrors { get; set; }

    }
}