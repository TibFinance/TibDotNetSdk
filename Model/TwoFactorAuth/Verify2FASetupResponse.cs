
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.TwoFactorAuth
{
    /// <summary>
    /// Represents the Verify2FASetupResponse model.
    /// </summary>
    public class Verify2FASetupResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Boolean flag indicating if the payment was created successfully
    /// </summary>
    /// <value>true when the payment is created and a paymentId is returned; false when the request fails and error details are provided</value>
    public bool Success { get; set; }

    /// <summary>
    /// Success message to display to the user (English). Populated when Success is true.
    /// </summary>
    public string Message { get; set; }

    /// <summary>
    /// Human‑readable description of the error that occurred while creating the payment
    /// </summary>
    /// <value>String returned only on failure; may be empty or null on success. Contains the API‑generated error message, up to 512 characters, suitable for logging or display to end users.</value>
    public string ErrorMessage { get; set; }

    }
}