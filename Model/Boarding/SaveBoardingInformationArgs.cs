
using System;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the SaveBoardingInformationArgs model.
    /// </summary>
    public class SaveBoardingInformationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool? IsDraft { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingInformationModel BoardingInformation { get; set; }

    }
}