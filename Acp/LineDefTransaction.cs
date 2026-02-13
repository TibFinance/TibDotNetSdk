
using System;
using System.Collections.Generic;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineDefTransaction : LineBaseWithHeader
    {
        
    /// <summary>
    /// Gets the segments.
    /// </summary>
    /// <value>The segments.</value>
    public IEnumerable<BaseTransaction> Segments { get; set; }

    }
}