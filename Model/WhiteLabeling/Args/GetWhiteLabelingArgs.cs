
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.WhiteLabeling.Args
{
    /// <summary>
    /// Represents the GetWhiteLabelingArgs model.
    /// </summary>
    public class GetWhiteLabelingArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// the unique identifier of an entity that will ger a new whitelabeling.
    /// </summary>
    /// <value></value>
    public Guid Id { get; set; }

    /// <summary>
    /// the entity type
    /// </summary>
    /// <value></value>
    public int? WhiteLabelingLevel { get; set; }

    /// <summary>
    /// Url entity
    /// </summary>
    /// <value></value>
    public string Url { get; set; }

    }
}