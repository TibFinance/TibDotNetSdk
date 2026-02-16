
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
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Retrieves or assigns the unique identifier for WhiteLabeling.
    /// </summary>
    /// <value>This property represents the unique identifier for a WhiteLabeling entity within the TIB Finance system. It is crucial for distinguishing between different WhiteLabeling configurations.</value>
    public Nullable<Guid> WhiteLabelingId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this service has a completed boarding (status 13 = approved).
    /// </summary>
    /// <value><c>true<c> if the service has at least one merchant with completed boarding; otherwise, <c>false<c>.</value>
    public bool HasCompletedBoarding { get; set; }

    }
}