
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetPaymentArgs model.
    /// </summary>
    public class GetPaymentArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Unique identifier of the newly created payment
    /// </summary>
    /// <value>System‑generated GUID (36‑character string), immutable and required for all subsequent payment‑related operations</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}