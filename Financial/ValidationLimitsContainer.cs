
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ValidationLimitsContainer 
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the limit status.
    /// </summary>
    /// <value>The limit status.</value>
    public ValidationLimitStatus LimitStatus { get; set; }

    /// <summary>
    /// Gets or sets the tib authorization.
    /// </summary>
    /// <value>The tib authorization.</value>
    public TibAuthorizationStatus TibAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the client authorization.
    /// </summary>
    /// <value>The client authorization.</value>
    public ClientAuthorizationStatus ClientAuthorization { get; set; }

    /// <summary>
    /// Gets or sets the tib messages.
    /// </summary>
    /// <value>The tib messages.</value>
    public List<string> TibMessages { get; set; }

    /// <summary>
    /// Gets or sets the client messages.
    /// </summary>
    /// <value>The client messages.</value>
    public List<string> ClientMessages { get; set; }

    }
}