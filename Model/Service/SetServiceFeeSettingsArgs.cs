
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SetServiceFeeSettingsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the ServiceFeeSettings model that defines the fee configuration for a specific service contract.
    /// </summary>
    /// <value>An instance of ServiceFeeSettingsModel containing fee rates, thresholds, and applicable rules.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    }
}