
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.General
{
    /// <summary>
    /// Represents the SendAdminAuthenticationCodeArgs model.
    /// </summary>
    public class SendAdminAuthenticationCodeArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Administrator code (login code)
    /// </summary>
    /// <value>The admin code.</value>
    public string AdminCode { get; set; }

    }
}