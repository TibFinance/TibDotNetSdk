
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the GetSupplierTransferArgs model.
    /// </summary>
    public class GetSupplierTransferArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Unique identifier of the wallet adjustment transaction
    /// </summary>
    /// <value>System‑generated GUID (UUID v4) returned in the response; immutable, required for tracking and correlation of the adjustment</value>
    public Guid TransferId { get; set; }

    }
}