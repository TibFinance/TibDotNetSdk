
using System;
using System.Collections.Generic;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Report
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class FeeSummary 
    {
        
    /// <summary>
    /// Gets or sets the total fee amount across all fees.
    /// </summary>
    /// <value></value>
    public decimal TotalFeeAmount { get; set; }

    /// <summary>
    /// Gets or sets the total count of fee transactions.
    /// </summary>
    /// <value></value>
    public int TotalFeeCount { get; set; }

    /// <summary>
    /// Gets or sets the total fees for credit card payments.
    /// </summary>
    /// <value></value>
    public decimal CreditCardFeesTotal { get; set; }

    /// <summary>
    /// Gets or sets the count of credit card fee transactions.
    /// </summary>
    /// <value></value>
    public int CreditCardFeesCount { get; set; }

    /// <summary>
    /// Gets or sets the total fees for direct account (bank) payments.
    /// </summary>
    /// <value></value>
    public decimal DirectAccountFeesTotal { get; set; }

    /// <summary>
    /// Gets or sets the count of direct account fee transactions.
    /// </summary>
    /// <value></value>
    public int DirectAccountFeesCount { get; set; }

    /// <summary>
    /// Gets or sets the total fees for Interac payments.
    /// </summary>
    /// <value></value>
    public decimal InteracFeesTotal { get; set; }

    /// <summary>
    /// Gets or sets the count of Interac fee transactions.
    /// </summary>
    /// <value></value>
    public int InteracFeesCount { get; set; }

    /// <summary>
    /// Gets or sets the breakdown of fees by fee type.
    /// </summary>
    /// <value></value>
    public Dictionary<OperationKindEnum, object> FeesByType { get; set; }

    }
}