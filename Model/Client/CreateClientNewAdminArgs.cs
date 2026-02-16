
using System;
using Tib.Api.Model.Client;
using Tib.Api.Model.Service;
using Tib.Api.Model.Merchant;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the CreateClientNewAdminArgs model.
    /// </summary>
    public class CreateClientNewAdminArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifies the TIB client (account) using its unique GUID.
    /// </summary>
    /// <value>The Client ID is a GUID assigned by TIB during account opening; it is required for session creation and other calls.</value>
    public ClientEntity Client { get; set; }

    /// <summary>
    /// The 'Password' property is a critical component in user authentication, safeguarding individualized user data.
    /// </summary>
    /// <value>This property stores a distinct string, representing the user's password, which is vital for user identification and data protection.</value>
    public string Password { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ClientLoginModel ClientLogin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ServiceEntity ServiceInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool CreateInnactive { get; set; }

    /// <summary>
    /// This property holds the basic information necessary for creating or updating a merchant's account within the TIB Finance API system.
    /// </summary>
    /// <value>Contains essential details about the merchant.</value>
    public MerchantModel MerchantInfo { get; set; }

    /// <summary>
    /// Gets or sets the ServiceFeeSettings model that defines the fee configuration for a specific service contract.
    /// </summary>
    /// <value>An instance of ServiceFeeSettingsModel containing fee rates, thresholds, and applicable rules.</value>
    public ServiceFeeSettingsModel ServiceFeeSettings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ServiceSettingsModel Settings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ClientSettings ClientSettings { get; set; }

    }
}