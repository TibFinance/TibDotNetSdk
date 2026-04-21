
using System;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the GetPaymentResponse model.
    /// </summary>
    public class GetPaymentResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The payment details associated with each recurring transfer returned by GetRecuringTransfers.
    /// </summary>
    /// <value>Contains amount, currency, execution date, and status of the scheduled payment; may be null if the transfer has no associated payment.</value>
    public PaymentModel Payment { get; set; }

    }
}