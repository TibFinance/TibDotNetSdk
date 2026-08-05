
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
    public string Base64 { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public BoardingIdFileSidesEnum Side { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public bool IsAdministrator { get; set; }

    }
}