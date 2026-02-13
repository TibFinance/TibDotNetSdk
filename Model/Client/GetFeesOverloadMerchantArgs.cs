
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetFeesOverloadMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Client information to modify
    /// </summary>
    /// <value>The client.</value>
    public Guid Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Source { get; set; }

    }
}