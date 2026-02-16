
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the PayoutData model.
    /// </summary>
    public class PayoutData 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Paid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime Date { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Gross { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal Fees { get; set; }

    }
}