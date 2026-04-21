
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetServiceResponse model.
    /// </summary>
    public class GetServiceResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Specifies the TIB Finance service (e.g., payments, savings) for which transfers are being listed
    /// </summary>
    /// <value>String, required; must match one of the platform's supported service identifiers (case‑sensitive enum).</value>
    public ServiceWithMerchantModel Service { get; set; }

    }
}