
using System;
using Tib.Api.Common;

namespace Tib.Api.ExternalDataVault
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PushDataResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the data identifier.
    /// </summary>
    /// <value>The data identifier.</value>
    public Guid DataId { get; set; }

    }
}