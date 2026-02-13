
using System;
using System.Collections.Generic;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetrieveDocumentResultEntity : BoardingBaseResult
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CaseStatus { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderRequestId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CaseId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<BoardingDocument> Documentation { get; set; }

    }
}