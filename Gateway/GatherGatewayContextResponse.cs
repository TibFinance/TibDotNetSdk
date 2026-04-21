
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
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// The total monetary amount due for the requested bill.
    /// </summary>
    /// <value>Decimal value in the account's currency, non‑negative, typically with two decimal places of precision (e.g., 1234.56).</value>
    public decimal BillAmount { get; set; }

    }
}