
using System;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the SaveServiceArgs model.
    /// </summary>
    public class SaveServiceArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the service associated with a merchant in the TIB Finance API. This property is crucial for managing service-related operations, including contract management and fee determination.
    /// </summary>
    /// <value>Represents the service entity linked to a merchant, encapsulating details necessary for API interactions.</value>
    public ServiceModel Service { get; set; }

    }
}