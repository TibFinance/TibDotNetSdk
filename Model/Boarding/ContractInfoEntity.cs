
using System;
using Tib.Api.Model.Boarding;
using Tib.Api.Model.Service;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the ContractInfoEntity model.
    /// </summary>
    public class ContractInfoEntity 
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public BoardingInformationEntity BoardingCompanyInfos { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ServiceFeeSettingsModel FeeSettings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public ServiceSettingsModel LimitationSettings { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public bool IsSignedContract { get; set; }

    /// <summary>
    /// The ClientId property serves as a distinct identifier for each client, playing a crucial role in the authentication process.
    /// </summary>
    /// <value>ClientId is a distinctive identifier, encapsulated as a Guid, allocated to every client for precise identification and authentication.</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    }
}