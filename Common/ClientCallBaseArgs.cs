using System;

namespace Tib.Api.Common
{
    /// <summary>
    ///  base Object for createing ApiCallArgs.
    /// </summary>
    public class ClientCallBaseArgs
    {
        /// <summary>
/// Gets or sets the session token.
/// </summary>
/// <value>The session token.</value>
public Guid? SessionToken { get; set; }
    }
}
