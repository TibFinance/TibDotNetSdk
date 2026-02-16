
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the SendAllClientBillsArgs model.
    /// </summary>
    public class SendAllClientBillsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    /// <summary>
    /// Gets or sets the year.
    /// </summary>
    /// <value>The year.</value>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    /// <value>The month.</value>
    public int Month { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SendToQuickbook { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool SendToQuickbookByEmail { get; set; }

    }
}