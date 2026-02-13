
using System;
using Tib.Api.Model.Customer;
using Tib.Api.Common;

namespace Tib.Api.Model.Customer
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SaveCustomerArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Provides access to detailed customer information necessary for transaction processing and account management.
    /// </summary>
    /// <value>Represents the customer entity within the system, encapsulating all relevant customer data.</value>
    public CustomerModel Customer { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}