
using System;
using Tib.Api.Common;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
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
    /// <value><c>true<c> if this instance is manager account; otherwise, <c>false<c>.</value>
    public bool IsManagerAccount { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// Use for Pay Collect Access
    /// </summary>
    /// <value>IsPayCollecAccess</value>
    public bool IsReadOnly { get; set; }

    }
}