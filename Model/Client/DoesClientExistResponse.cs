
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DoesClientExistResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether this instance is client existing.
    /// </summary>
    /// <value><c>true<c> if this instance is client existing; otherwise, <c>false<c>.</value>
    public bool IsClientExisting { get; set; }

    }
}