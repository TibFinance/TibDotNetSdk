
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the SubmitDocumentToBlueSnapResponse model.
    /// </summary>
    public class SubmitDocumentToBlueSnapResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    /// <summary>
    /// Represents a textual message within the system, used for communication or logging purposes.
    /// </summary>
    /// <value>The 'Message' type is utilized to convey information, warnings, or errors throughout the application. It serves as a standard format for displaying or recording messages.</value>
    public string Message { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Count { get; set; }

    }
}