
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BaseLoggedSession 
    {
        
    /// <summary>
    /// Determine the last activity of this session
    /// </summary>
    /// <value>The last activity date.</value>
    public DateTime LastActivityDate { get; set; }

    /// <summary>
    /// Determine the date of the Session creation date
    /// </summary>
    /// <value>The creation date.</value>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Retrieves or assigns the identifier for user login relations.
    /// </summary>
    /// <value>Represents the unique identifier associated with user login relations.</value>
    public Guid LoginsUserRelationsId { get; set; }

    /// <summary>
    /// The permission Type, will defined the level of permission and will also define What is the reference to the InternalReferenceid If you set Merchant or Client, the internal referenceid should be a merchant or a client
    /// </summary>
    /// <value>The type of the permission.</value>
    public LoginType PermissionType { get; set; }

    }
}