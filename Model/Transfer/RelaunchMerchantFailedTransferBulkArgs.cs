
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.Transfer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RelaunchMerchantFailedTransferBulkArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> TransferIds { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}