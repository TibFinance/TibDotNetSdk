
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the ProviderEntity model.
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