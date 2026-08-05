
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
    /// List of executed operations matching the query criteria.
    /// </summary>
    public List<FreeCollectionOperationModel> OperationList { get; set; }

    }
}