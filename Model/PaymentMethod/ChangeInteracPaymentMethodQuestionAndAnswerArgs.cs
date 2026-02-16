
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
    /// Represents the unique identifier for an Interac payment method associated with a customer account.
    /// </summary>
    /// <value>This identifier is used to specify which Interac payment method should be updated or accessed within the API.</value>
    public Guid InteracPaymentMethodId { get; set; }

    /// <summary>
    /// The question displayed to the Interac recipient to request acceptance of a deposit.
    /// </summary>
    /// <value>Holds the question text as a string.</value>
    public string InteracQuestion { get; set; }

    /// <summary>
    /// InteracAnswer is the response string that the target must provide to accept an Interac deposit.
    /// </summary>
    /// <value>Holds the answer supplied by the Interac recipient to confirm the deposit operation.</value>
    public string InteracAnswer { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid? MerchantId { get; set; }

    }
}