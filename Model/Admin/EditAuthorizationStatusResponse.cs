
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class EditAuthorizationStatusResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string AuthorizationStatus { get; set; }

    }
}