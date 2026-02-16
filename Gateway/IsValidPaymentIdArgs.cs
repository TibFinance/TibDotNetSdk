
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway
{
    /// <summary>
    /// Represents the IsValidPaymentIdArgs model.
    /// </summary>
    public class IsValidPaymentIdArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    }
}