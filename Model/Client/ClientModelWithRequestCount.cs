
using System;
using Tib.Api.Model.Boarding;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the ClientModelWithRequestCount model.
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