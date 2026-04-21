
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway
{
    /// <summary>
    /// Represents the IsValidPaymentIdResponse model.
    /// </summary>
    public class IsValidPaymentIdResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this instance is valid payment identifier.
    /// </summary>
    /// <value>&lt;c&gt;true&lt;c&gt; if this instance is valid payment identifier; otherwise, &lt;c&gt;false&lt;c&gt;.</value>
    public bool IsValidPaymentId { get; set; }

    }
}