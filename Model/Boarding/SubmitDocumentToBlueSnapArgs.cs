
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the SubmitDocumentToBlueSnapArgs model.
    /// </summary>
    public class SubmitDocumentToBlueSnapArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderRequestId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocType { get; set; }

    /// <summary>
    /// Gets or sets the title that identifies the object in a human‑readable way.
    /// </summary>
    /// <value>A short, descriptive string displayed in user interfaces and reports.</value>
    public string Title { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string FileType { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Content { get; set; }

    }
}