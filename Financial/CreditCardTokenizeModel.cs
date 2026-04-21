
using System;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the CreditCardTokenizeModel model.
    /// </summary>
    public class CreditCardTokenizeModel 
    {
        
    /// <summary>
    /// Gets or sets the card token.
    /// </summary>
    /// <value>The card token.</value>
    public string CardToken { get; set; }

    /// <summary>
    /// Returns true if ... is valid.
    /// </summary>
    /// <value>true if this instance is valid; otherwise, false.</value>
    public bool IsValid { get; set; }

    /// <summary>
    /// Human‑readable description of the error that occurred while creating the payment
    /// </summary>
    /// <value>String returned only on failure; may be empty or null on success. Contains the API‑generated error message, up to 512 characters, suitable for logging or display to end users.</value>
    public string ErrorMessage { get; set; }

    }
}