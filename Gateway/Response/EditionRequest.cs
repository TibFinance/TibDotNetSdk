
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Response
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class EditionRequest 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Content { get; set; }

    /// <summary>
    /// Represents the current state of a transaction within the system.
    /// </summary>
    /// <value>The Status integer indicates the progress or outcome of a transaction, providing essential information for error handling and process monitoring.</value>
    public ContractRequestStatusEnum Status { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string CreationDate { get; set; }

    }
}