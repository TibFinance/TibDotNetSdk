
using System;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the ServiceModel model.
    /// </summary>
    public class ServiceModel : ServiceEntity
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Identifier of the white‑label partner linked to the merchant, if any.
    /// </summary>
    /// <value>Nullable GUID; present only when the merchant is part of a white‑label arrangement, otherwise null. Must be a valid UUID when provided.</value>
    public Nullable<Guid> WhiteLabelingId { get; set; }

    /// <summary>
    /// Indicates whether the service has finished its onboarding process.
    /// </summary>
    /// <value>True when all required boarding steps are completed; false otherwise. Read‑only, always present in the GetService response.</value>
    public bool HasCompletedBoarding { get; set; }

    }
}