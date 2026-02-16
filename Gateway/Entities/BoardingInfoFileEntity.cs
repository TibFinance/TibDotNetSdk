
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Gateway.Entities
{
    /// <summary>
    /// Represents the BoardingInfoFileEntity model.
    /// </summary>
    public class BoardingInfoFileEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Base64 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingIdFileSidesEnum Side { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsAdministrator { get; set; }

    }
}