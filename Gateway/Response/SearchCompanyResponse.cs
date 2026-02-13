
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class SearchCompanyResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string NeqOrNi { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CompanyName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AddressDisplay { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CreationDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsQuebec { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool HasDetails { get; set; }

    }
}