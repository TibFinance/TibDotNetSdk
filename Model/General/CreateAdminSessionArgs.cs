
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CreateAdminSessionArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// The admin code sent by email
    /// </summary>
    /// <value>The temporary admin code.</value>
    public string TemporaryAdminCode { get; set; }

    }
}