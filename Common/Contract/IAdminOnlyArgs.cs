
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common.Contract
{
    /// <summary>
    /// Represents the IAdminOnlyArgs interface.
    /// </summary>
    public interface IAdminOnlyArgs 
    {
        
    /// <summary>
    /// Gets or sets the admin session token.
    /// </summary>
    /// <value>The admin session token.</value>
    public Guid? AdminSessionToken { get; set; }

    }
}