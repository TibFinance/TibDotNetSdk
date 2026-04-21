
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the LoggedUserInformation model.
    /// </summary>
    public class LoggedUserInformation : BaseLoggedSession
    {
        
    /// <summary>
    /// Gets or sets the internal reference identifier.
    /// </summary>
    /// <value>The internal reference identifier.</value>
    public Guid InternalReferenceId { get; set; }

    /// <summary>
    /// Gets or sets the login identifier.
    /// </summary>
    /// <value>The login identifier.</value>
    public Guid LoginId { get; set; }

    /// <summary>
    /// Gets or sets the user client identifier.
    /// </summary>
    /// <value>The user client identifier.</value>
    public Guid UserClientId { get; set; }

    /// <summary>
    /// The login identifier of the user initiating the session.
    /// </summary>
    /// <value>String, required, case‑sensitive, typically an email or account name; maximum length 256 characters; must correspond to a valid TIB Finance user.</value>
    public string Username { get; set; }

    /// <summary>
    /// Gets or sets the first name of the user.
    /// </summary>
    /// <value>The first name of the user.</value>
    public string UserFirstName { get; set; }

    /// <summary>
    /// Gets or sets the last name of the user.
    /// </summary>
    /// <value>The last name of the user.</value>
    public string UserLastName { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is manager account.
    /// </summary>
    /// <value>true if this instance is manager account; otherwise, false.</value>
    public bool IsManagerAccount { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// Use for Pay Collect Access
    /// </summary>
    /// <value>IsPayCollecAccess</value>
    public bool IsReadOnly { get; set; }

    /// <summary>
    /// Indicates if this session was created via admin impersonation. When true, 2FA checks are bypassed since the admin has already authenticated.
    /// </summary>
    /// <value></value>
    public bool IsImpersonatedSession { get; set; }

    /// <summary>
    /// The LoginId of the admin who is impersonating this user. Used for audit logging when IsImpersonatedSession is true.
    /// </summary>
    /// <value></value>
    public Guid? ImpersonatingAdminId { get; set; }

    /// <summary>
    /// List of ServiceIds that this login has access to via LoginsRelations. Populated only for Service-level logins.
    /// </summary>
    /// <value></value>
    public HashSet<Guid> AllowedServiceIds { get; set; }

    }
}