
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the GetReferenceInformationResponse model.
    /// </summary>
    public class GetReferenceInformationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ReferenceDataString1 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid ReferenceDataGuid1 { get; set; }

    }
}