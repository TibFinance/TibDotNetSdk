
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the ChangeInteracPaymentMethodQuestionAndAnswerResponse model.
    /// </summary>
    public class ChangeInteracPaymentMethodQuestionAndAnswerResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Identifier of the payment method to be set as the default for the account
    /// </summary>
    /// <value>Must be a valid, non‑empty GUID referencing an existing, active payment method owned by the caller; cannot be null or belong to another tenant.</value>
    public Guid PaymentMethodId { get; set; }

    }
}