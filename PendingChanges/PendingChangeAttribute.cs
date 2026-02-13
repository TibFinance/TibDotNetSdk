
using System;

namespace Tib.Api.PendingChanges
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PendingChangeAttribute : Attribute
    {
        
    /// <summary>
    /// Gets or sets a value indicating whether [do not render on public pending change].
    /// </summary>
    /// <value><c>true<c> if [do not render on public pending change]; otherwise, <c>false<c>.</value>
    public bool DoNotRenderOnPublicPendingChange { get; set; }

    }
}