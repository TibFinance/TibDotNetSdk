
using System;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPaymentResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents a payment transaction within the TIB Finance API, facilitating the transfer of funds between accounts.
    /// </summary>
    /// <value>This entity encapsulates the details of a payment transaction, including the necessary identifiers and financial information, to ensure accurate processing.</value>
    public PaymentModel Payment { get; set; }

    }
}