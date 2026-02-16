
using System;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the GetBoardingInformationResponse model.
    /// </summary>
    public class GetBoardingInformationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingInformationModel BoardingInfo { get; set; }

    }
}