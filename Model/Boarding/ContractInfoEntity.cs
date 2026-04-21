
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
    /// Unique identifier of the client initiating the session
    /// </summary>
    /// <value>Required Guid; must be a valid, registered client ID in the TIB Finance system</value>
    public Guid ClientId { get; set; }

    /// <summary>
    /// The unique identifier of the merchant initiating the payment request.
    /// </summary>
    /// <value>Must be a valid GUID representing a registered merchant; cannot be empty or null.</value>
    public Guid MerchantId { get; set; }

    }
}