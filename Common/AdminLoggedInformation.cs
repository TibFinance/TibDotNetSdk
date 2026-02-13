
using System;
using Tib.Api.Common;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AdminLoggedInformation : BaseLoggedSession
    {
        
    /// <summary>
    /// Gets or sets the admin identifier.
    /// </summary>
    /// <value>The admin identifier.</value>
    public Guid AdminID { get; set; }

    }
}