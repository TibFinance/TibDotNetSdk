
using System;
using System.Collections.Generic;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetTransferCreationListResponse model.
    /// </summary>
    public class GetTransferCreationListResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the transfers creations.
    /// </summary>
    /// <value>The transfers creations.</value>
    public List<TransferCreationModel> TransfersCreations { get; set; }

    }
}