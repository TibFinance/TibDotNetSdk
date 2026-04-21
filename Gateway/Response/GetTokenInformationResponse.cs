
using System;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Represents the GetTokenInformationResponse model.
    /// </summary>
    public class GetTokenInformationResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The name of the service that processed the transfer
    /// </summary>
    /// <value>String, non‑empty, max length 64 characters; reflects the internal service identifier returned in the ListTransfers response</value>
    public string ServiceName { get; set; }

    }
}