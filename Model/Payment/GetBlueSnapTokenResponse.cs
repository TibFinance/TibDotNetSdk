
using System;
using Tib.Api.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBlueSnapTokenResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public GetBlueSnapClientTokenResponse GetBlueSnapClientTokenResponse { get; set; }

    }
}