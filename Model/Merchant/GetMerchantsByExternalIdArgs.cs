
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetMerchantsByExternalIdArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Represents the unique identifier for a merchant within an external system. This ID is crucial for integrating and synchronizing merchant data across different platforms.
    /// </summary>
    /// <value>Serves as the external system identifier, linking the merchant to external databases or services.</value>
    public string ExternalSystemId { get; set; }

    /// <summary>
    /// Represents the external identity associated with a merchant within an external system.
    /// </summary>
    /// <value>Serves as the identifier for the group in an external system, facilitating the integration and management of merchant data across platforms.</value>
    public string ExternalSystemGroupId { get; set; }

    }
}