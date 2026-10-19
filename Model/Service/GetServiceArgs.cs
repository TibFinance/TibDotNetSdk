
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetServiceArgs model.
    /// </summary>
    public class GetServiceArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Identifier of the service for which recurring transfers are requested
    /// </summary>
    /// <value>Required GUID; must correspond to an existing service owned by the caller</value>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// Not used by GetService.
    /// </summary>
    public Guid? MerchantId { get; set; }

    }
}