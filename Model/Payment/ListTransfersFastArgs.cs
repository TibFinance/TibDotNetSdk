
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
    /// First calendar day of the payment-due-date range (inclusive). Only the date part is used; days are Eastern Time calendar days. Required.
    /// </summary>
    /// <value>From date.</value>
    public DateTime? FromDate { get; set; }

    /// <summary>
    /// Last calendar day of the payment-due-date range (inclusive). Only the date part is used; days are Eastern Time calendar days. Required.
    /// </summary>
    /// <value>To date.</value>
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
    /// Identifier of the transfer group to filter the listed transfers
    /// </summary>
    /// <value>String, non‑empty, case‑sensitive; must match an existing TransferGroupId (e.g., UUID or alphanumeric up to 64 characters).</value>
    public string TransferGroupId { get; set; }

    /// <summary>
    /// Indicates the category of the recurring transfer (e.g., inbound, outbound, internal).
    /// </summary>
    /// <value>Enum TransferTypeEnum; possible values: INBOUND, OUTBOUND, INTERNAL. Returned in uppercase; null if not applicable.</value>
    public TransferTypeEnum TransferType { get; set; }

    /// <summary>
    /// Indicates whether to return only transfers that have been resolved
    /// </summary>
    /// <value>Boolean flag; true filters the list to resolved transfers only, false (or omitted) returns all transfers. Must be a valid bool value.</value>
    public bool MarkResolvedOnly { get; set; }

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