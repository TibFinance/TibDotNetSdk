
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
    /// Start date of the wallet operations date range filter.
    /// </summary>
    /// <value></value>
    public DateTime From { get; set; }

    /// <summary>
    /// End date of the wallet operations date range filter.
    /// </summary>
    /// <value></value>
    public DateTime To { get; set; }

    }
}