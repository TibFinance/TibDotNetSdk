
using System;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Responses
{
    /// <summary>
    /// Represents the UpdateWhiteLabelingDataResonse model.
    /// </summary>
    public class UpdateWhiteLabelingDataResonse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}