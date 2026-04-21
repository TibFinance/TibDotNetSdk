
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
    /// <value></value>
    public int TransferCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ExternalId { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
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