
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the ProviderMerchantCredentialEntity model.
    /// </summary>
    public class ProviderMerchantCredentialEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string UserName { get; set; }

    /// <summary>
    /// The account password used to authenticate the session request
    /// </summary>
    /// <value>String, required, non‑empty; must meet the platform's password policy (minimum length, allowed characters) and is transmitted securely</value>
    public string Password { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DataProtectionKey { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    }
}