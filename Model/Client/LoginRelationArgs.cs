
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LoginRelationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid InternalReferenceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int InternalReferenceType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid LoginId { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    }
}