
using System;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the GetChangeValidationResponse model.
    /// </summary>
    public class GetChangeValidationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the json object.
    /// </summary>
    /// <value>The json object.</value>
    public string JsonObject { get; set; }

    /// <summary>
    /// Gets or sets the validation token.
    /// </summary>
    /// <value>The validation token.</value>
    public Guid ValidationToken { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}