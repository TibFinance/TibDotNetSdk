
using System;
using System.Collections.Generic;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ListClientsBoardingResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// List of boarding clients
    /// </summary>
    /// <value>The clients.</value>
    public IEnumerable<ClientModelBoarding> Clients { get; set; }

    }
}