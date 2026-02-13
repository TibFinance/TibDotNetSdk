
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPaymentMethodFeesResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal GrossTotal { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ConvenientFeeAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ProcessingFeeFixedAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ProcessingFeeTotal { get; set; }

    }
}