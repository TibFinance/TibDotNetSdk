
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
    /// <value><c>true<c> if this instance is valid; otherwise, <c>false<c>.</value>
    public bool IsValid { get; set; }

    /// <summary>
    /// The ErrorMessage property provides a textual description of any error encountered during the execution of a function or process.
    /// </summary>
    /// <value>This property contains a string that details the nature of the error, aiding in debugging and error handling.</value>
    public string ErrorMessage { get; set; }

    }
}