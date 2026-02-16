
using System;
using System.Collections.Generic;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the ListClientsBoardingResponse model.
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