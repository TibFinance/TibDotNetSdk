
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetPublicTokenRoutingTypeResponse model.
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