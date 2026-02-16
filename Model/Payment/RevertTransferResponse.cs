
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
    /// Gets a value indicating whether the record has been deleted.
    /// </summary>
    /// <value>True when the record is marked as deleted; otherwise false.</value>
    public bool HasBeenDeleted { get; set; }

    }
}