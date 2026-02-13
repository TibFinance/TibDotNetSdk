
using System;
using System.Collections.Generic;
using Tib.Api.Model.FreeOperation;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateFreeOperationBatchArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Facilitates the initiation of a batch of free operations, enabling transactions that are not associated with a specific bill. This is crucial for managing payments or deposits directly linked to customer payment methods.
    /// </summary>
    /// <value>This property allows for the creation of multiple free operations in a single batch, optimizing the process of handling transactions that are independent of bills.</value>
    public List<FreeOperationModel> FreeOperationBatchList { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Determines whether to halt operations with identical identifications.
    /// </summary>
    /// <value>This boolean property is used to control the processing of transactions that share the same identification values, such as GroupId or ReferenceNumber.</value>
    public bool? StopSameIdentifications { get; set; }

    }
}