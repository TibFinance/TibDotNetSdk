
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Represents the GetSubClientArgs model.
    /// </summary>
    public class GetSubClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the unique identifier for a sub-client.
    /// </summary>
    /// <value>This property represents the unique identifier for a sub-client within the TIB system, ensuring precise identification and management of sub-client entities.</value>
    public Guid SubClientId { get; set; }

    }
}