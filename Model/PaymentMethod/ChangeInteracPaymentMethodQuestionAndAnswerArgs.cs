
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.PaymentMethod
{
    /// <summary>
    /// Represents the ChangeInteracPaymentMethodQuestionAndAnswerArgs model.
    /// </summary>
    public class ChangeInteracPaymentMethodQuestionAndAnswerArgs : ClientCallBaseArgs, IMerchantArgs
    {
        
    /// <summary>
    /// Identity of the Interac Payment Method
    /// </summary>
    public Guid InteracPaymentMethodId { get; set; }

    /// <summary>
    /// The security question presented to the payer for an Interac e‑Transfer payment.
    /// </summary>
    /// <value>String, required; up to 255 characters; must be UTF‑8; used to verify the payer’s identity during payment creation.</value>
    public string InteracQuestion { get; set; }

    /// <summary>
    /// The answer to the security question required for creating an Interac payment method.
    /// </summary>
    /// <value>String, required; must match the answer previously set for the Interac e‑Transfer account; typically 1‑255 characters; case‑sensitive; trimmed of leading/trailing whitespace.</value>
    public string InteracAnswer { get; set; }

    /// <summary>
    /// Merchant ID to scope this operation to. Automatically set for merchant-level logins.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}