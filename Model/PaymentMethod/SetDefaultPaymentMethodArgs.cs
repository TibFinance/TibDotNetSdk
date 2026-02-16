
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
    /// Serves as a unique identifier for each customer within the system.
    /// </summary>
    /// <value>The 'CustomerId' is a unique, non-duplicable identifier that is assigned to each customer upon their creation. It functions as a primary key for all operations related to a specific customer.</value>
    public Guid CustomerId { get; set; }

    /// <summary>
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    }
}