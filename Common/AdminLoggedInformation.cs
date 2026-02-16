
using System;
using Tib.Api.Common;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the AdminLoggedInformation model.
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