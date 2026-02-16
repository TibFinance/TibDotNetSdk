
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
    /// Identifies a specific recurring transfer operation associated with a client's account.
    /// </summary>
    /// <value>This GUID uniquely represents a recurring transfer, allowing for precise management and retrieval of transfer details.</value>
    public Guid RecuringTransferId { get; set; }

    }
}