
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateSessionResponse : ClientBaseResponse, ITibSession
    {
        
    /// <summary>
    /// The SessionId property serves as a unique identifier for each user session, encapsulated as a Guid, facilitating a secure and personalized user experience.
    /// </summary>
    /// <value>The SessionId property denotes a unique identifier, expressed as a Guid, assigned to each user session, thereby ensuring its distinctiveness and security.</value>
    public Guid SessionId { get; set; }

    }
}