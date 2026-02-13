
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransferValidationRequestArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="TransferValidationRequestArgs"> is approved.
    /// </summary>
    /// <value><c>true<c> if approved; otherwise, <c>false<c>.</value>
    public bool Approved { get; set; }

    }
}