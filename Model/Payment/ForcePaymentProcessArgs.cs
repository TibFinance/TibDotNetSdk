
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ForcePaymentProcessArgs model.
    /// </summary>
    public class ForcePaymentProcessArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid PaymentId { get; set; }

    }
}