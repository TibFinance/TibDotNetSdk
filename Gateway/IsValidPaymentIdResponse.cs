
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class IsValidPaymentIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this instance is valid payment identifier.
    /// </summary>
    /// <value><c>true<c> if this instance is valid payment identifier; otherwise, <c>false<c>.</value>
    public bool IsValidPaymentId { get; set; }

    }
}