
using System;
using Tib.Api.Boarding;

namespace Tib.Api.Boarding
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class GetBoardingMerchantStatusResultEntity : BoardingBaseResult
    {
        
    /// <summary>
    /// Represents the merchant's unique name.
    /// </summary>
    /// <value>This property holds a string value that uniquely identifies the merchant by name.</value>
    public string MerchantName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string MerchantEmail { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ProviderMerchantId { get; set; }

    /// <summary>
    /// The MerchantId property retrieves or assigns a unique Guid identifier for a specific merchant.
    /// </summary>
    /// <value>The MerchantId property signifies a unique Guid identifier that corresponds to a specific merchant within the system.</value>
    public Guid MerchantId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string SandboxId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Processing { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string Payout { get; set; }

    }
}