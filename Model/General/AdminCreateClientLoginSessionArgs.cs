
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the AdminCreateClientLoginSessionArgs model.
    /// </summary>
    public class AdminCreateClientLoginSessionArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    }
}