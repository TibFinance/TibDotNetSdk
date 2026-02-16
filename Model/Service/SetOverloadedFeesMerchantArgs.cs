
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the SetOverloadedFeesMerchantArgs model.
    /// </summary>
    public class SetOverloadedFeesMerchantArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Generates a unique identifier for a specific service to facilitate the creation of a customer list.
    /// </summary>
    /// <value>Serves as a unique key that distinctly identifies a specific service within the system.</value>
    public Guid? ServiceId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid OverloadedMerchantId { get; set; }

    }
}