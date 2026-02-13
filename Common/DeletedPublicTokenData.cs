
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DeletedPublicTokenData 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DeletedPublicTokenReasonEnum? Reason { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ReferenceData { get; set; }

    }
}