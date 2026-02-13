
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.ConvenientFee
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeleteConvenientFeeSettingsArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid Id { get; set; }

    }
}