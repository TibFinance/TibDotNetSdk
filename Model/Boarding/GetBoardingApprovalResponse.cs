
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Boarding
{
    /// <summary>
    /// Represents the GetBoardingApprovalResponse model.
    /// </summary>
    public class GetBoardingApprovalResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public string ApprovalStatus { get; set; }

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