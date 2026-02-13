
using System;
using Tib.Api.Das;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasPaymentQuebecEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasDateField PeriodStartDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasDateField PeriodEndDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal WithhodingTax { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal RetirementPensionPlan { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal HealthServiceFund { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal ParentalInsurancePlan { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal CNESST { get; set; }

    }
}