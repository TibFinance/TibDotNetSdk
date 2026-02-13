
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CheckTransferRevertableResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsRevertable { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Reason { get; set; }

    }
}