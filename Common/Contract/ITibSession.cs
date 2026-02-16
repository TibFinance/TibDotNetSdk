
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Common.Contract
{
    /// <summary>
    /// Represents the ITibSession interface.
    /// </summary>
    public interface ITibSession 
    {
        
    /// <summary>
    /// The SessionId property serves as a unique identifier for each user session, encapsulated as a Guid, facilitating a secure and personalized user experience.
    /// </summary>
    /// <value>The SessionId property denotes a unique identifier, expressed as a Guid, assigned to each user session, thereby ensuring its distinctiveness and security.</value>
    public Guid SessionId { get; set; }

    }
}