
using System;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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