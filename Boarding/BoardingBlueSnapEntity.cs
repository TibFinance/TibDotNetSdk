
using System;
using System.Collections.Generic;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingBlueSnapEntity : BoardingEntity
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object BusinessInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object BankingInfo { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<object> OwnershipInfoArr { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object CompanyRep { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<object> AdditionalCompanyReps { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public object MerchantAgreementsSign { get; set; }

    }
}