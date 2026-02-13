
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.BinInfo
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBinInfoArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Bin { get; set; }

    }
}