
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the ListTransfersFastResponse model.
    /// </summary>
    public class ListTransfersFastResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<TransferBaseInformationEntity> Transfers { get; set; }

    }
}