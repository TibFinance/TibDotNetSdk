
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
    /// The BoardingServiceId uniquely identifies a boarding service within the system. It is essential for tracking and managing the onboarding process of merchants.
    /// </summary>
    /// <value>This property holds a unique identifier in the form of a GUID, which is crucial for referencing specific boarding services.</value>
    public Guid BoardingServiceId { get; set; }

    }
}