
using System;
using System.Collections.Generic;
using Tib.Api.Model.ConvenientFee;
using Tib.Api.Common;

namespace Tib.Api.Model.ConvenientFee
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetConvenientFeeSettingsByMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public IEnumerable<ConvenientFeeSettingsModel> ConvenientFeeSettings { get; set; }

    }
}