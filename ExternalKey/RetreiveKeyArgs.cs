
using System;
using Tib.Api.Common;

namespace Tib.Api.ExternalKey
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetreiveKeyArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the encryption key.
    /// </summary>
    /// <value>The encryption key.</value>
    public Guid EncryptionKey { get; set; }

    }
}