
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Supplier
{
    /// <summary>
    /// Represents the ListSupplierTransfersResponse model.
    /// </summary>
    public class ListSupplierTransfersResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A collection of basic information for each transfer linked to the specified bill.
    /// </summary>
    /// <value>Contains TransferBaseInformationEntity objects (id, amount, status, timestamps, etc.). May be empty if no transfers exist. Ordered by creation time descending. No pagination applied; all matching transfers are returned.</value>
    public List<TransferBaseInformationEntity> Transfers { get; set; }

    }
}