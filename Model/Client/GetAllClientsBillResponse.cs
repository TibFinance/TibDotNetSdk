
using System;
using System.Collections.Generic;
using Tib.Api.Model.Client;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetAllClientsBillResponse model.
    /// </summary>
    public class GetAllClientsBillResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<MontlyBillInfo> BillsInfo { get; set; }

    }
}