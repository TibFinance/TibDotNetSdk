
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeleteMerchantLoginArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Retrieves or assigns the identifier for user login relations.
    /// </summary>
    /// <value>Represents the unique identifier associated with user login relations.</value>
    public Guid LoginsUserRelationsId { get; set; }

    }
}