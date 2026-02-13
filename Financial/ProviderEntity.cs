
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ProviderEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid ProviderId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ProviderEnum ProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int OrderPriority { get; set; }

    }
}