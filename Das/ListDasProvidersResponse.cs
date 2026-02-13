
using System;
using System.Collections.Generic;
using Tib.Api.Das;
using Tib.Api.Common;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListDasProvidersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<DasProviderModelCanada> CanadaDasProvider { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<DasProviderModelQuebec> QuebecDasProvider { get; set; }

    }
}