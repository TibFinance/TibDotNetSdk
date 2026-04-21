
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersFastArgs model.
    /// </summary>
    public class ListTransfersFastArgs : ClientCallBaseArgs
    {
        
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
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Identifier of the transfer group to filter the fast transfer list
    /// </summary>
    /// <value>String, required; must be a valid UUID (36 characters, hyphenated) representing an existing TransferGroupId</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// If true, the request returns only transfers that are marked as resolved.
    /// </summary>
    /// <value>Boolean input; default false. When set to true, unresolved transfers are excluded from the result set. No other status filters may be applied concurrently.</value>
    public bool MarkResolvedOnly { get; set; }

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