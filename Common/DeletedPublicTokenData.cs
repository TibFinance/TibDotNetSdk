
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the DeletedPublicTokenData model.
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