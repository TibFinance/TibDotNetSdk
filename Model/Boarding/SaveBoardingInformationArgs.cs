
using System;
using Tib.Api.Model.Boarding;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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