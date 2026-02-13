
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateServiceResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the created service identifier.
    /// </summary>
    /// <value>The created service identifier.</value>
    public Guid CreatedServiceId { get; set; }

    }
}