
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway
{
    /// <summary>
    /// Represents the GatherGatewayContextResponse model.
    /// </summary>
    public class GatherGatewayContextResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Specifies the monetary amount of a bill to be created.
    /// </summary>
    /// <value>Decimal value representing the total amount due for the bill. Must be greater than zero.</value>
    public decimal BillAmount { get; set; }

    }
}