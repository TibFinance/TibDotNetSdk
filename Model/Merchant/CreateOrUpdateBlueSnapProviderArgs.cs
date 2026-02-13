
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateOrUpdateBlueSnapProviderArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BsMerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BsUsername { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BsPassword { get; set; }

    }
}