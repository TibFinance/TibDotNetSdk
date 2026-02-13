
using System;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasDateField 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Day { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Month { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int Year { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime DateTimeValue { get; set; }

    }
}