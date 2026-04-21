
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Represents the DeleteRecuringTransferArgs model.
    /// </summary>
    public class DeleteRecuringTransferArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the recurring transfer to delete
    /// </summary>
    /// <value>Guid; must reference an existing active recurring transfer; required and immutable</value>
    public Guid RecuringTransferId { get; set; }

    }
}