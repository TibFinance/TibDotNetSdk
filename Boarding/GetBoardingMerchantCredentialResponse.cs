
using System;
using Tib.Api.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBoardingMerchantCredentialResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public GetBoardingMerchantCredentialResultEntity GetBoardingMerchantCredentialResultEntity { get; set; }

    }
}