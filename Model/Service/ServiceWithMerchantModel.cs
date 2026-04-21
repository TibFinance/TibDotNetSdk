
using System;
using Tib.Api.Model.Merchant;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ServiceWithMerchantModel model.
    /// </summary>
    public class ServiceWithMerchantModel : ServiceModel
    {
        
    /// <summary>
    /// The primary merchant linked to the requested service.
    /// </summary>
    /// <value>Returned as a MerchantViewModel containing merchant ID, name, and status; may be null if the service has no primary merchant. Read‑only field in the GetService response.</value>
    public MerchantViewModel ServicePrimaryMerchant { get; set; }

    /// <summary>
    /// Configuration of fees applied to the service.
    /// </summary>
    /// <value>Encapsulates fee rates, thresholds, currency, and calculation rules; fields are read‑only and represent the active fee schedule for the queried service.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    /// <summary>
    /// The ServiceSettingsModel object that defines the configuration of the requested service.
    /// </summary>
    /// <value>Includes endpoint URLs, authentication requirements, rate limits, and feature toggles. Returned only for services the caller is authorized to view; fields are read‑only and may be null if the service has no configurable settings.</value>
    public ServiceSettingsModel ServiceSettings { get; set; }

    /// <summary>
    /// The merchant name linked to any overloaded fees applied to the transaction.
    /// </summary>
    /// <value>String, up to 100 characters; may be empty if no overloaded fees are present; UTF‑8 encoded.</value>
    public string OverloadedFeesMerchantName { get; set; }

    }
}