
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
    /// Acts as a unique identifier for a distinct payment method.
    /// </summary>
    /// <value>This unique identifier, or token, is specifically associated with a single payment method.</value>
    public Guid PaymentMethodId { get; set; }

    }
}