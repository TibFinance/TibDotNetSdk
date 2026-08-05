
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the CreateSubClientResponse model.
    /// </summary>
    public class CreateSubClientResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// When the client is not boarding-exempt, the URL to redirect the new service's boarding wizard to (auto-InitBoarding). Null/empty for boarding-exempt clients or if the auto-InitBoarding could not be started (the service is still created and usable to board manually).
    /// </summary>
    public string BoardingRedirectUrl { get; set; }

    }
}