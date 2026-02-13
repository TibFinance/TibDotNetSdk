
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Gateway.Args
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetReferenceInformationArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ReferenceData { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public GetReferenceInformationTypeEnum ReferenceInformationType { get; set; }

    }
}