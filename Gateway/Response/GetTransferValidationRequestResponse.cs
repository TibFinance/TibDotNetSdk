
using System;
using Tib.Api.Gateway.Entities;
using Tib.Api.Model.WhiteLabeling;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetTransferValidationRequestResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the transfer.
    /// </summary>
    /// <value>The transfer.</value>
    public TransferValidationEntity Transfer { get; set; }

    /// <summary>
    /// Gets or sets the WhiteLabelinf.
    /// </summary>
    /// <value>The WhiteLabeling.</value>
    public WhiteLabelingModel WhiteLabeling { get; set; }

    }
}