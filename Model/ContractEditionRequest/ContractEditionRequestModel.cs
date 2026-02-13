
using System;

namespace Tib.Api.Model.ContractEditionRequest
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ContractEditionRequestModel 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int ContractEditionRequestId { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RequestContent { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string RequestContentPreview { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CreatedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProcessedAt { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int RequestStatus { get; set; }

    /// <summary>
    /// The date and time when the payment was created.
    /// </summary>
    /// <value>A UTC DateTime indicating the exact moment the payment record was generated.</value>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DateTime? ProcessedDate { get; set; }

    }
}