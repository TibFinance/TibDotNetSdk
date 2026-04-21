
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Represents the TransferValidationRequestArgs model.
    /// </summary>
    public class TransferValidationRequestArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this &lt;see cref="TransferValidationRequestArgs"&gt; is approved.
    /// </summary>
    /// <value>&lt;c&gt;true&lt;c&gt; if approved; otherwise, &lt;c&gt;false&lt;c&gt;.</value>
    public bool Approved { get; set; }

    }
}