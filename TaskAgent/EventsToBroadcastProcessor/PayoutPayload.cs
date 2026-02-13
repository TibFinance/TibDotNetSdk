
using System;
using System.Collections.Generic;
using Tib.Api.TaskAgent.EventsToBroadcastProcessor;

namespace Tib.Api.TaskAgent.EventsToBroadcastProcessor
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class PayoutPayload 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PayoutId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ExternalId { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public string Currency { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PayoutDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int TransferCount { get; set; }

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
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public string CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<TransferPayload> Transferts { get; set; }

    }
}