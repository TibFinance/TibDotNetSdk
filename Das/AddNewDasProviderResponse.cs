
using System;
using Tib.Api.Common;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class AddNewDasProviderResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid? DasProviderId { get; set; }

    }
}