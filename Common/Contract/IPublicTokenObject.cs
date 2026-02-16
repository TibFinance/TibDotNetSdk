
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common.Contract
{
    /// <summary>
    /// Represents the IPublicTokenObject interface.
    /// </summary>
    public interface IPublicTokenObject 
    {
        
    /// <summary>
    /// Gets or sets the public token identifier.
    /// </summary>
    /// <value>The public token identifier.</value>
    public Guid PublicTokenId { get; set; }

    }
}