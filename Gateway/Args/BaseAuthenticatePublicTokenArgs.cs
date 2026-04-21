
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the BaseAuthenticatePublicTokenArgs model.
    /// </summary>
    public class BaseAuthenticatePublicTokenArgs : ClientCallBaseArgs, IPublicTokenObject
    {
        
    /// <summary>
    /// Gets or sets the public token identifier.
    /// </summary>
    /// <value>The public token identifier.</value>
    public Guid PublicTokenId { get; set; }

    }
}