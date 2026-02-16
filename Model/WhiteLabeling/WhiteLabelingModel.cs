
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;

namespace Tib.Api.Model.WhiteLabeling
{
    /// <summary>
    /// Represents the WhiteLabelingModel model.
    /// </summary>
    public class WhiteLabelingModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid WhileLabelingId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int WhiteLabelingLevel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string WhiteLabelingLevelValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Logo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Url { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingDataModel> WhiteLabelingData { get; set; }

    }
}