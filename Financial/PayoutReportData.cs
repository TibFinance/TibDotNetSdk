
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PayoutReportData 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int TransferCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ExternalId { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime PayoutDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal GrossAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ProcessingFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ConvenientFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal NonProcessingFeesAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal TotalPaidAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal RefundsAmount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<string> NonProcessingDescriptions { get; set; }

    }
}