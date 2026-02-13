
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetAcpTypesArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Client information to modify
    /// </summary>
    /// <value>The client.</value>
    public Guid RelatedId { get; set; }

    }
}