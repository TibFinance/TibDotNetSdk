
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPublicTokenRoutingTypeArgs : ClientCallBaseArgs, IPublicTokenObject
    {
        
    /// <summary>
    /// Gets or sets the identifier of the public token required to initiate a drop‑in session.
    /// </summary>
    /// <value>A GUID that uniquely identifies the public token issued by TIB Finance.</value>
    public Guid PublicTokenId { get; set; }

    }
}