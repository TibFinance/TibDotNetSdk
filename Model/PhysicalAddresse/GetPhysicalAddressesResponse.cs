
using System;
using System.Collections.Generic;
using Tib.Api.Common;

namespace Tib.Api.Model.PhysicalAddresse
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetPhysicalAddressesResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Dictionary<int, string> Countries { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Dictionary<int, string> Provinces { get; set; }

    }
}