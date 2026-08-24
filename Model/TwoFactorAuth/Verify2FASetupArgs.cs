
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.TwoFactorAuth
{
    /// <summary>
    /// Represents the Verify2FASetupArgs model.
    /// </summary>
    public class Verify2FASetupArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The 6-digit TOTP code from the user's authenticator app. User must enter this after scanning the QR code to confirm setup.
    /// </summary>
    public string TwoFactorCode { get; set; }

    }
}