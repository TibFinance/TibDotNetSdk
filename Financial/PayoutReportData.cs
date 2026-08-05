
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the PayoutReportData model.
    /// </summary>
    public class PayoutReportData 
    {
        
    /// <summary>
    /// 
    /// </summary>
    public int TransferCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string ExternalId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime PayoutDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal GrossAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal ProcessingFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal ConvenientFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal NonProcessingFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal TotalPaidAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public decimal RefundsAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public List<string> NonProcessingDescriptions { get; set; }

    }
}