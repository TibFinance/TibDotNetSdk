
using System;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetDropInResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the drop in.
    /// </summary>
    /// <value>The drop in.</value>
    public DropInEntity DropIn { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}