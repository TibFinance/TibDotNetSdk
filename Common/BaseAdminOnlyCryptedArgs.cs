
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BaseAdminOnlyCryptedArgs : ClientCallBaseArgs, IAdminOnlyArgs
    {
        
    /// <summary>
    /// Gets or sets the admin session token.
    /// </summary>
    /// <value>The admin session token.</value>
    public Guid? AdminSessionToken { get; set; }

    }
}