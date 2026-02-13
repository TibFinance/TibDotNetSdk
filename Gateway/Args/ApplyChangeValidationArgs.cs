
using System;
using Tib.Api.Gateway.Args;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ApplyChangeValidationArgs : BaseAuthenticatePublicTokenArgs
    {
        
    /// <summary>
    /// This token is provided by the PendingChange. The method GetChangeValidation in the Gateway provide the necessery information
    /// </summary>
    /// <value>The validation token.</value>
    public Guid ValidationToken { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [change approved].
    /// </summary>
    /// <value><c>true<c> if [change approved]; otherwise, <c>false<c>.</value>
    public bool ChangeApproved { get; set; }

    }
}