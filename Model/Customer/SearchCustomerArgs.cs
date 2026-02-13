
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchCustomerArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// This property represents the full name of the customer in the system.
    /// </summary>
    /// <value>The 'CustomerName' is a string attribute that holds the complete name of the customer as registered in the system.</value>
    public string CustomerName { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}