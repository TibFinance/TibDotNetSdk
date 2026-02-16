
using System;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Responses
{
    /// <summary>
    /// Represents the GetWhiteLabelingResponse model.
    /// </summary>
    public class GetWhiteLabelingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}