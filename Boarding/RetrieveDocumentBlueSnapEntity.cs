
using System;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetrieveDocumentBlueSnapEntity : RetrieveDocumentEntity
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
    public string CaseId { get; set; }

    }
}