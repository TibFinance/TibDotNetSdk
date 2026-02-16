
using System;
using System.Collections.Generic;
using Tib.Api.Model.Boarding;
using Tib.Api.Gateway.Response;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the LoadContractCompanyInfosResponse model.
    /// </summary>
    public class LoadContractCompanyInfosResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ContractInfoEntity CompanyInfos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<EditionRequest> EditionRequests { get; set; }

    }
}