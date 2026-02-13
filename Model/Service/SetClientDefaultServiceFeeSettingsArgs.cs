
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SetClientDefaultServiceFeeSettingsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// Gets or sets the ServiceFeeSettings model that defines the fee configuration for a specific service contract.
    /// </summary>
    /// <value>An instance of ServiceFeeSettingsModel containing fee rates, thresholds, and applicable rules.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    }
}