
using System;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ClientLoginModel 
    {
        
    /// <summary>
    /// The identity of the login
    /// </summary>
    /// <value>The client login identifier.</value>
    public Guid? ClientLoginId { get; set; }

    /// <summary>
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
    public string Username { get; set; }

    /// <summary>
    /// The user first name
    /// </summary>
    /// <value>The firstname.</value>
    public string Firstname { get; set; }

    /// <summary>
    /// The user last name
    /// </summary>
    /// <value>The lastname.</value>
    public string Lastname { get; set; }

    /// <summary>
    /// Specifies the email address associated with the merchant.
    /// </summary>
    /// <value>Represents the merchant's email address, which is used for communication and identification purposes within the TIB Finance API.</value>
    public string Email { get; set; }

    /// <summary>
    /// LoginType
    /// </summary>
    /// <value>LoginType.</value>
    public int? LoginType { get; set; }

    /// <summary>
    /// LoginType
    /// </summary>
    /// <value>ReferenceType.</value>
    public string ReferenceType { get; set; }

    /// <summary>
    /// LoginType
    /// </summary>
    /// <value>ReferenceType.</value>
    public string Reference { get; set; }

    /// <summary>
    /// InternalRefernceId
    /// </summary>
    /// <value>InternalRefernceId.</value>
    public Guid? InternalRefernceIds { get; set; }

    /// <summary>
    /// InternalRefernceId
    /// </summary>
    /// <value>LoginRelationsId.</value>
    public Guid? LoginRelationId { get; set; }

    }
}