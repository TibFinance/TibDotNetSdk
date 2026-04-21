
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the RevertTransferResponse model.
    /// </summary>
    public class RevertTransferResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Whether the transfer was successfully deleted as part of the revert operation.
    /// </summary>
    /// <value></value>
    public bool HasBeenDeleted { get; set; }

    }
}