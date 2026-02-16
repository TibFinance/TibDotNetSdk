
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model
{
    /// <summary>
    /// Represents the FlatFileEntry model.
    /// </summary>
    public class FlatFileEntry<T> : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public T Value { get; set; }

    }
}