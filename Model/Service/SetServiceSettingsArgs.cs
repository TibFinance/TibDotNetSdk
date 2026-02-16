
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the SetServiceSettingsArgs model.
    /// </summary>
    public class SetServiceSettingsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    /// <value>The settings.</value>
    public ServiceSettingsModel Settings { get; set; }

    }
}