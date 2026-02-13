
using System;
using System.Collections.Generic;
using Tib.Api.Model.Payment;
using Tib.Api.Common;

namespace Tib.Api.Model.Payment
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetDepositOperationsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides the collection of free‑collection operations that have been executed.
    /// </summary>
    /// <value>A list of FreeCollectionOperationModel instances, each representing a single operation.</value>
    public List<OperationModel> OperationList { get; set; }

    }
}