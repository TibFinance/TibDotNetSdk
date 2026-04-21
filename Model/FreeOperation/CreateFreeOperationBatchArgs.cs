
using System;
using System.Collections.Generic;
using Tib.Api.Model.FreeOperation;
using Tib.Api.Common;

namespace Tib.Api.Model.FreeOperation
{
    /// <summary>
    /// Represents the CreateFreeOperationBatchArgs model.
    /// </summary>
    public class CreateFreeOperationBatchArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// List of free operations to create as a batch.
    /// </summary>
    /// <value></value>
    public List<FreeOperationModel> FreeOperationBatchList { get; set; }

    /// <summary>
    /// Identifier of the payment group to which the payment belongs
    /// </summary>
    /// <value>String, required, non‑empty, max 36 characters, must be a valid UUID/GUID if the system uses GUIDs</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Whether to reject duplicate operations with the same identification details within the group.
    /// </summary>
    /// <value></value>
    public bool? StopSameIdentifications { get; set; }

    }
}