
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateServiceArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Gets or sets the service information.
    /// </summary>
    /// <value>The service information.</value>
    public ServiceEntity ServiceInfo { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [create innactive].
    /// </summary>
    /// <value><c>true<c> if [create innactive]; otherwise, <c>false<c>.</value>
    public bool CreateInnactive { get; set; }

    }
}