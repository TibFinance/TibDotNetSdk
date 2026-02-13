
using System;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingDocument 
    {
        
    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public string Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocUnderWriterNotes { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocsReceived { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocLimit { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocGenericDescription { get; set; }

    }
}