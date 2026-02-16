
using System;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the BoardingFileModel model.
    /// </summary>
    public class BoardingFileModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid BoardingInfoFilesId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderCaseId { get; set; }

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

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string DocStatus { get; set; }

    }
}