
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the GetServiceBoardingStatusArgs model.
    /// </summary>
    public class GetServiceBoardingStatusArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the boarding service whose status is being retrieved.
    /// </summary>
    /// <value>Required GUID; must correspond to an existing boarding service; must be a valid, non‑empty GUID string.</value>
    public Guid BoardingServiceId { get; set; }

    }
}