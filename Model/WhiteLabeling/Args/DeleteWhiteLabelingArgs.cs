
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeleteWhiteLabelingArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid Id { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Level { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Url { get; set; }

    }
}