
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetCustomersByExternalIdArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the identifier used for external customer identification. This property is crucial for linking customer data with external systems.
    /// </summary>
    /// <value>Represents the unique identifier for a customer used in external systems.</value>
    public string ExternalCustomerId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}