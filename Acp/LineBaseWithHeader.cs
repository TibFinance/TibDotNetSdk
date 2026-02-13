
using System;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineBaseWithHeader : LineBase
    {
        
    /// <summary>
    /// Gets or sets the header.
    /// </summary>
    /// <value>The header.</value>
    public BaseLineHeader Header { get; set; }

    /// <summary>
    /// Gets the start position.
    /// </summary>
    /// <value>The start position.</value>
    public int StartPosition { get; set; }

    }
}