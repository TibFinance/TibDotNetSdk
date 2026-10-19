
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the CreateMerchantResponse model.
    /// </summary>
    public class CreateMerchantResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Created merchant identity
    /// </summary>
    /// <value>The merchant identifier.</value>
    public Guid MerchantId { get; set; }

    }
}