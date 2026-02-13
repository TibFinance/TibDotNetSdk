
using System;
using Tib.Api.Model.PaymentMethod;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPaymentMethodResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides detailed information about a customer's payment method, which may include credit card, bank account, or Interac details.
    /// </summary>
    /// <value>Represents the specific payment method associated with a customer, crucial for transaction processing.</value>
    public PaymentMethodModel PaymentMethod { get; set; }

    }
}