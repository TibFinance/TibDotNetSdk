
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class CredentialValueType 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public CredentialTypeEnum CredentialType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public String CredentialValue { get; set; }

    }
}