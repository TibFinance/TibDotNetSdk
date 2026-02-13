
using System;

namespace Tib.Api.Model.BinInfo
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BinInfoDto 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Bin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Brand { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CardType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Category { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CountryCode { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CountryName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string PricingGroup { get; set; }

    }
}