
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Das;
using Tib.Api.Common;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AddNewDasProviderArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// The provider type to create. Must match with the corresponding object filled.
    /// </summary>
    /// <value></value>
    public DasProviderTypeEnum DasProviderType { get; set; }

    /// <summary>
    /// Quebec provider to be created
    /// </summary>
    /// <value></value>
    public DasProviderEntityQuebec DasProviderQuebec { get; set; }

    /// <summary>
    /// Canada provider to be created
    /// </summary>
    /// <value></value>
    public DasProviderEntityCanada DasProviderCanada { get; set; }

    }
}