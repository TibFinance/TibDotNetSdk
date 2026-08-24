
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the ListExecutedOperationsArgs model.
    /// </summary>
    public class ListExecutedOperationsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Start of the date range filter, UTC (inclusive). Applies to the transaction's creation date by default, or its last-modified date when DateType selects it. Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>From date.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// End of the date range filter, UTC (inclusive). Applies to the transaction's creation date by default, or its last-modified date when DateType selects it. Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>To date.</value>
    public DateTime? ToDate { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeFlag TransferType { get; set; }

    /// <summary>
    /// Identifier of the transfer group to filter the listed transfers
    /// </summary>
    /// <value>String, non‑empty, case‑sensitive; must match an existing TransferGroupId (e.g., UUID or alphanumeric up to 64 characters).</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// When true, the request returns only transfers that have errors.
    /// </summary>
    /// <value>Optional boolean; defaults to false (returns all transfers). Must be a valid JSON boolean.</value>
    public bool OnlyWithErrors { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Which date field to use for the date range filter (CreatedDate or LastModifiedDate).
    /// </summary>
    public DateTypeEnum? DateType { get; set; }

    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid? ServiceId { get; set; }

    }
}