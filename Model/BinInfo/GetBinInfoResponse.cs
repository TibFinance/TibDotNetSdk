
using System;
using Tib.Api.Model.BinInfo;
using Tib.Api.Common;

namespace Tib.Api.Model.BinInfo
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBinInfoResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BinInfoDto BinInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool Found { get; set; }

    }
}