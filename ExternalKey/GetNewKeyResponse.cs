
using System;
using Tib.Api.Common;

namespace Tib.Api.ExternalKey
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetNewKeyResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the token.
    /// </summary>
    /// <value>The token.</value>
    public Guid Token { get; set; }

    /// <summary>
    /// Gets or sets the key.
    /// </summary>
    /// <value>The key.</value>
    public byte[] Key { get; set; }

    }
}