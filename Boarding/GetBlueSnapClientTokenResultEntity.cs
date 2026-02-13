
using System;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBlueSnapClientTokenResultEntity : BoardingBaseResult
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Token { get; set; }

    }
}