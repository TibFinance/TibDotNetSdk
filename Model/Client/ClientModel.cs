
using System;
using Tib.Api.Model.Client;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the ClientModel model.
    /// </summary>
    public class ClientModel : ClientEntity
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for WhiteLabeling.
    /// </summary>
    /// <value>This property represents the unique identifier for a WhiteLabeling entity within the TIB Finance system. It is crucial for distinguishing between different WhiteLabeling configurations.</value>
    public Nullable<Guid> WhiteLabelingId { get; set; }

    }
}