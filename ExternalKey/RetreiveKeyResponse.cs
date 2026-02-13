
using System;
using Tib.Api.Common;

namespace Tib.Api.ExternalKey
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetreiveKeyResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    /// <value>The key.</value>
    public byte[] Key { get; set; }

    }
}