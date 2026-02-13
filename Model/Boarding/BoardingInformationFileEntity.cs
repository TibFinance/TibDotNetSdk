
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class BoardingInformationFileEntity 
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

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingDocTypeEnum DocType { get; set; }

    }
}