
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the ProcessDropInResponse model.
    /// </summary>
    public class ProcessDropInResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    }
}