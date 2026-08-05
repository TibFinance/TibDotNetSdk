
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
    public Guid WhileLabelingId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public int WhiteLabelingLevel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string WhiteLabelingLevelValue { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Logo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string Url { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<WhiteLabelingDataModel> WhiteLabelingData { get; set; }

    }
}