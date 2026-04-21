
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the SetDefaultPaymentMethodArgs model.
    /// </summary>
    public class SetDefaultPaymentMethodArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Unique identifier of the customer owning the recurring transfers
    /// </summary>
    /// <value>A non‑null GUID that matches an existing customer record; used to correlate transfers with the correct account</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Identifier of the payment method to be set as the default for the account
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID referencing an existing, active payment method owned by the caller; cannot be null or belong to another tenant.</value>
    public Guid PaymentMethodId { get; set; }

    }
}