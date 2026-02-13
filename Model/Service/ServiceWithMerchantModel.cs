
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ServiceWithMerchantModel : ServiceModel
    {
        
    /// <summary>
    /// Retrieves or assigns the primary merchant associated with the service.
    /// </summary>
    /// <value>This property represents the primary merchant for the service, which is crucial for handling transactions and managing merchant-specific operations.</value>
    public MerchantViewModel ServicePrimaryMerchant { get; set; }

    /// <summary>
    /// Gets or sets the ServiceFeeSettings model that defines the fee configuration for a specific service contract.
    /// </summary>
    /// <value>An instance of ServiceFeeSettingsModel containing fee rates, thresholds, and applicable rules.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    /// <summary>
    /// Gets or sets the configuration settings for a TIB Finance service.
    /// </summary>
    /// <value>An instance of ServiceSettingsModel that defines the service's contract identifier, applicable limits, fees, and other operational parameters.</value>
    public ServiceSettingsModel ServiceSettings { get; set; }

    /// <summary>
    /// Specifies the merchant name that is charged for fees when an override is applied.
    /// </summary>
    /// <value>A string containing the merchant's display name. The name must match an existing merchant record in TIB Finance.</value>
    public string OverloadedFeesMerchantName { get; set; }

    }
}