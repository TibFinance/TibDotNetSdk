
using System;
using System.Collections.Generic;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SetWhiteLabelingArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WhiteLabelingDataModel> WhiteLabelingData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int WhiteLabelingLevel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Url { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Logo { get; set; }

    }
}