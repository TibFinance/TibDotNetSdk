
using System;
using Tib.Api.Model.Client;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the GetClientSettingsResponse model.
    /// </summary>
    public class GetClientSettingsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// All merchant information
    /// </summary>
    /// <value>The merchants.</value>
    public ClientSettings ClientSettings { get; set; }

    /// <summary>
    /// Gets or sets the configuration settings for a TIB Finance service.
    /// </summary>
    /// <value>An instance of ServiceSettingsModel that defines the service's contract identifier, applicable limits, fees, and other operational parameters.</value>
    public ServiceSettingsModel ServiceSettings { get; set; }

    /// <summary>
    /// Gets or sets the ServiceFeeSettings model that defines the fee configuration for a specific service contract.
    /// </summary>
    /// <value>An instance of ServiceFeeSettingsModel containing fee rates, thresholds, and applicable rules.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    }
}