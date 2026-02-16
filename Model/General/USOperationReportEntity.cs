
using System;
using System.Collections.Generic;
using Tib.Api.Model.General;
using Tib.Api.Model.Payment;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the USOperationReportEntity model.
    /// </summary>
    public class USOperationReportEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public PayoutData Payout { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<TransferBaseInformationEntity> Transfers { get; set; }

    }
}