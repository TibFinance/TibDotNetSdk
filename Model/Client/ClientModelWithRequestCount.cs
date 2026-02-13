
using System;
using Tib.Api.Model.Boarding;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ClientModelWithRequestCount : ClientModelBoarding
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int WaitingRequestsCount { get; set; }

    }
}