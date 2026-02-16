
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the DoesClientExistResponse model.
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