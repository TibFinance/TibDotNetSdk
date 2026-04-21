
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the GetMerchantsByExternalIdArgs model.
    /// </summary>
    public class GetMerchantsByExternalIdArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the external system that owns the merchant ID
    /// </summary>
    /// <value>String (max 50 chars), required, case‑sensitive; must match the external system's unique identifier used to locate merchants linked to that system</value>
    public string ExternalSystemId { get; set; }

    /// <summary>
    /// Identifier of the external system group for the merchant lookup
    /// </summary>
    /// <value>String (max 50 chars), required, case‑sensitive, must correspond to an existing external system group; scopes the search performed by GetMerchantsByExternalId</value>
    public string ExternalSystemGroupId { get; set; }

    }
}