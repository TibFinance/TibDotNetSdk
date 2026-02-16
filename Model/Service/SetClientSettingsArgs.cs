
using System;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the SetClientSettingsArgs model.
    /// </summary>
    public class SetClientSettingsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the client settings.
    /// </summary>
    /// <value>The client settings.</value>
    public ClientSettings ClientSettings { get; set; }

    }
}