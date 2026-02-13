
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetSessionCookiesAdminResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The SessionId property serves as a unique identifier for each user session, encapsulated as a Guid, facilitating a secure and personalized user experience.
    /// </summary>
    /// <value>The SessionId property denotes a unique identifier, expressed as a Guid, assigned to each user session, thereby ensuring its distinctiveness and security.</value>
    public String SessionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int LoginTypeId { get; set; }

    /// <summary>
    /// The 'Username' property functions as a unique identifier for each user, facilitating personalized user interactions within the system.
    /// </summary>
    /// <value>This property holds a unique string value that differentiates each user, thus enabling tailored operations and interactions.</value>
    public string Username { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public string Language { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsReadOnly { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? InternalReferenceId { get; set; }

    }
}