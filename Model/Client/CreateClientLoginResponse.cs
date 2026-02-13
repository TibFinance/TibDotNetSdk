
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateClientLoginResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Id of the created user
    /// </summary>
    /// <value>The client login identifier.</value>
    public Guid ClientLoginId { get; set; }

    }
}