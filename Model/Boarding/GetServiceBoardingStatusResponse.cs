
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
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// List of merchants and their boarding details for the requested service.
    /// </summary>
    /// <value>Array of BoardingServiceMerchant objects; may be empty if no merchants are associated. Each entry contains merchantId, boardingStatus, and relevant timestamps. Read‑only; order not guaranteed.</value>
    public List<BoardingServiceMerchant> BoardingServiceMerchants { get; set; }

    }
}