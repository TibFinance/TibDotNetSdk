
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the InteracModel model.
    /// </summary>
    public class InteracModel 
    {
        
    /// <summary>
    /// This information will be displayed to the user
    /// </summary>
    /// <value>The Interac information description.</value>
    public string Description { get; set; }

    /// <summary>
    /// The name of the person having the account
    /// </summary>
    public string Owner { get; set; }

    /// <summary>
    /// The address where to send the Interac request
    /// </summary>
    public string TargetEmailAddress { get; set; }

    /// <summary>
    /// The mobile phone number that receives the Interac request. Any formatting of a 10-digit North American number is accepted (spaces, dashes, dots, parentheses, an optional +1 or 1 prefix); the platform keeps the 10 digits. The field is optional; a value that contains no digits is stored as empty.
    /// </summary>
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