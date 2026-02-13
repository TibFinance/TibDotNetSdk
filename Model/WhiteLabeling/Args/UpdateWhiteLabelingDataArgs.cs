
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class UpdateWhiteLabelingDataArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingDataModel> UpdatedWhiteLabelingData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid WhiteLabelId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Logo { get; set; }

    }
}