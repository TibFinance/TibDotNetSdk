
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the RelaunchOperationArgs model.
    /// </summary>
    public class RelaunchOperationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OperationId { get; set; }

    }
}