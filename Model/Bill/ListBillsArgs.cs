
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Bill
{
    /// <summary>
    /// Represents the ListBillsArgs model.
    /// </summary>
    public class ListBillsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The merchant whose bills are listed. If null, the bills of every merchant of the requested service are returned. For a merchant-level login, always that login's own merchant.
    /// </summary>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Start of the bill creation-date range filter, UTC (inclusive). Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>From date time.</value>
    public DateTime? FromDateTime { get; set; }

    /// <summary>
    /// End of the bill creation-date range filter, UTC (inclusive). Send an ISO-8601 value with a trailing Z.
    /// </summary>
    /// <value>To date time.</value>
    public DateTime? ToDateTime { get; set; }

    }
}