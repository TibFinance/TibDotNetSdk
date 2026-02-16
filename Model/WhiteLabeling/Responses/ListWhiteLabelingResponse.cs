
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Responses
{
    /// <summary>
    /// Represents the ListWhiteLabelingResponse model.
    /// </summary>
    public class ListWhiteLabelingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingModel> whiteLabelings { get; set; }

    }
}