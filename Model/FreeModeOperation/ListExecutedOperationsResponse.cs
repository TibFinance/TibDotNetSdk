
using System;
using System.Collections.Generic;
using Tib.Api.Model.FreeModeOperation;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeModeOperation
{
    /// <summary>
    /// Represents the ListExecutedOperationsResponse model.
    /// </summary>
    public class ListExecutedOperationsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Provides the collection of free‑collection operations that have been executed.
    /// </summary>
    /// <value>A list of FreeCollectionOperationModel instances, each representing a single operation.</value>
    public List<FreeCollectionOperationModel> OperationList { get; set; }

    }
}