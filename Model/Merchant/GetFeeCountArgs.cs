
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetFeeCountArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    /// <value>The month.</value>
    public int Month { get; set; }

    /// <summary>
    /// Gets or sets the year.
    /// </summary>
    /// <value>The year.</value>
    public int Year { get; set; }

    }
}