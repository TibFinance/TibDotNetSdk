
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProcessStatusResponse model.
    /// </summary>
    public class ProcessStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<TransactionSatusResultEntity> TransmissionResults { get; set; }

    }
}