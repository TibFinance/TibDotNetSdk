
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPublicTokenRoutingTypeResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the type of the routing.
    /// </summary>
    /// <value>The type of the routing.</value>
    public PublicAccessTokenRoutingType RoutingType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}