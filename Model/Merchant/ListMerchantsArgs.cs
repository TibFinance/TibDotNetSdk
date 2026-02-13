
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListMerchantsArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Gets or sets whether to include client merchants in the results. Default is false (excludes client merchants for backward compatibility).
    /// </summary>
    /// <value>True to include client merchants, false to exclude them.</value>
    public bool IncludeClientMerchants { get; set; }

    }
}