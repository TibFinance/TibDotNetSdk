
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Represents the UpdateDefaultWhiteLabelingDataArgs model.
    /// </summary>
    public class UpdateDefaultWhiteLabelingDataArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingDataModel> UpdatedWhiteLabelingData { get; set; }

    }
}