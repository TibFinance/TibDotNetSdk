
using System;

namespace Tib.Api.Model.WhiteLabeling
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class WhiteLabelingDataModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid WhiteLabelingDataId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CssProperty { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CssValue { get; set; }

    }
}