
using System;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Responses
{
    /// <summary>
    /// Represents the SetWhiteLabelingResponse model.
    /// </summary>
    public class SetWhiteLabelingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}