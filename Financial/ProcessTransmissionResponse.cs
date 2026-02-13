
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProcessTransmissionResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the transmission results.
    /// </summary>
    /// <value>The transmission results.</value>
    public List<TransactionResultEntity> TransmissionResults { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompressedTransmissionResults { get; set; }

    }
}