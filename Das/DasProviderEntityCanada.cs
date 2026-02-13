
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Das;

namespace Tib.Api.Das
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class DasProviderEntityCanada : DasProviderBase
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasProviderTypeEnum DasProviderType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string BusinessOrAccountNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasProviderCanadaFileTypeEnum FileType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string FileNumber { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public DasProviderCanadaDeclarationFrequencyEnum DeclarationFrequency { get; set; }

    /// <summary>
    /// Provides a detailed explanation of the function's purpose and usage within the API.
    /// </summary>
    /// <value>This property offers a comprehensive description of how the function interacts with the API, detailing its role in retrieving customer data associated with a merchant account.</value>
    public string Description { get; set; }

    }
}