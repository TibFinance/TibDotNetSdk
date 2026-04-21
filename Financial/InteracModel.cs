
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the InteracModel model.
    /// </summary>
    public class InteracModel 
    {
        
    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    /// <summary>
    /// Identifier of the entity that owns the payment method.
    /// </summary>
    /// <value>String, non‑empty, typically a UUID or account ID representing the user or merchant; immutable for the lifetime of the method.</value>
    public string Owner { get; set; }

    /// <summary>
    /// The email address of the payer to which the Interac payment request will be sent.
    /// </summary>
    /// <value>Must be a valid RFC‑5322 email string, non‑empty, maximum 254 characters. Required for CreateInteracPaymentMethod.</value>
    public string TargetEmailAddress { get; set; }

    /// <summary>
    /// The mobile phone number of the payer to which the Interac payment will be sent
    /// </summary>
    /// <value>String in E.164 format (e.g., +1XXXXXXXXXX); must be a valid Canadian mobile number, digits only, max 15 characters, required.</value>
    public string TargetMobilePhoneNumber { get; set; }

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

    }
}