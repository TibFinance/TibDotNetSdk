
using System;
using Tib.Api.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class RetrieveDocumentResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public RetrieveDocumentResultEntity RetrieveDocumentResultEntity { get; set; }

    }
}