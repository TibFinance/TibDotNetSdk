
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the CredentialValueType model.
    /// </summary>
    public class CredentialValueType 
    {
        
    /// <summary>
    /// 
    /// </summary>
    public CredentialTypeEnum CredentialType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public String CredentialValue { get; set; }

    }
}