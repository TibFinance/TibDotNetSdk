
using System;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SubmitDocumentResultEntity : BoardingBaseResult
    {
        
    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    }
}