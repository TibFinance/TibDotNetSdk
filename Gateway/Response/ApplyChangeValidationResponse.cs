
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the ApplyChangeValidationResponse model.
    /// </summary>
    public class ApplyChangeValidationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether [record is modify].
    /// </summary>
    /// <value>&lt;c&gt;true&lt;c&gt; if [record is modify]; otherwise, &lt;c&gt;false&lt;c&gt;.</value>
    public bool RecordIsModify { get; set; }

    }
}