
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Das;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasPaymentQuebecModel : DasPaymentQuebecEntity
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a payment.
    /// </summary>
    /// <value>Represents the unique identifier associated with a specific payment transaction.</value>
    public Guid PaymentId { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public DasPaymentProcessStatusEnum Status { get; set; }

    }
}