
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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