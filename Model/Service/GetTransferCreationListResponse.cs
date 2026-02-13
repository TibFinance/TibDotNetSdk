
using System;
using System.Collections.Generic;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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