
using System;
using System.Collections.Generic;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the FeatureToggleExpressionModel model.
    /// </summary>
    public class FeatureToggleExpressionModel 
    {
        
    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> ServiceIds { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<Guid> MerchantIds { get; set; }

    }
}