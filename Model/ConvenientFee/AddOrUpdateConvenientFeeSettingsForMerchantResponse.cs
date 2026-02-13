
using System;
using Tib.Api.Model.ConvenientFee;
using Tib.Api.Common;

namespace Tib.Api.Model.ConvenientFee
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AddOrUpdateConvenientFeeSettingsForMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ConvenientFeeSettingsModel ConvenientFeeSettings { get; set; }

    }
}