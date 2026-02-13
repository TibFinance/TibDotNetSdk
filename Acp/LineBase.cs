
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineBase : FlatFileLine
    {
        
    /// <summary>
    /// Gets the default padding character.
    /// </summary>
    /// <value>The default padding character.</value>
    public char DefaultPaddingChar { get; set; }

    /// <summary>
    /// Gets the default padding direction.
    /// </summary>
    /// <value>The default padding direction.</value>
    public PadDirectionEnum DefaultPaddingDirection { get; set; }

    }
}