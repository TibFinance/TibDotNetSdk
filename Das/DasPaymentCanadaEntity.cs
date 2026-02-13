
using System;
using Tib.Api.Das;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasPaymentCanadaEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasMonthlyPeriod PeriodEndDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int LastPayPeriodEmployeeCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal PeriodRawRemuneration { get; set; }

    /// <summary>
    /// Specifies the amount to be paid. The value must not exceed the sum of the associated bill amount and any previously recorded payments. If null, the system applies the remaining unpaid portion of the bill.
    /// </summary>
    /// <value>The monetary amount of the payment, expressed as a decimal number.</value>
    public decimal PaymentAmount { get; set; }

    }
}