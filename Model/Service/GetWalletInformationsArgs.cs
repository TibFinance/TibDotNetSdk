
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetWalletInformationsArgs model.
    /// </summary>
    public class GetWalletInformationsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    }
}