
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetWalletOperationsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime From { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime To { get; set; }

    }
}