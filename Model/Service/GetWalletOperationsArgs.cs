
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetWalletOperationsArgs model.
    /// </summary>
    public class GetWalletOperationsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Start of the wallet-operations date range filter, UTC (inclusive). Values are compared directly against UTC-stored timestamps — send an ISO-8601 value with a trailing Z.
    /// </summary>
    public DateTime From { get; set; }

    /// <summary>
    /// End of the wallet-operations date range filter, UTC (inclusive). Send an ISO-8601 value with a trailing Z. The range must not exceed 366 days, and To must not be earlier than From.
    /// </summary>
    public DateTime To { get; set; }

    }
}