
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model
{
    /// <summary>
    /// Represents the FlatFileLine model.
    /// </summary>
    public class FlatFileLine : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public char DefaultPaddingChar { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PadDirectionEnum DefaultPaddingDirection { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int StartPosition { get; set; }

    }
}