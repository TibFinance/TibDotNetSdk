
using System;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the BoardingInfoResponse model.
    /// </summary>
    public class BoardingInfoResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Information about the boarding proccess of the client.
    /// </summary>
    /// <value></value>
    public BoardingInformationModel BoardingInfo { get; set; }

    }
}