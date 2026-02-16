
using System;
using System.Collections.Generic;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the GetServiceBoardingStatusResponse model.
    /// </summary>
    public class GetServiceBoardingStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Provides access to a collection of merchants who have successfully completed the onboarding process. This list is crucial for tracking and managing the status of merchant onboarding within the system.
    /// </summary>
    /// <value>This property does not require additional parameters beyond the standard API call structure.</value>
    public List<BoardingServiceMerchant> BoardingServiceMerchants { get; set; }

    }
}