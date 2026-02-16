
using System;
using System.Collections.Generic;
using Tib.Api.Financial;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the GetFeeCountResponse model.
    /// </summary>
    public class GetFeeCountResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// Gets or sets the transaction fees agregated.
    /// </summary>
    /// <value>The transaction fees agregated.</value>
    public List<MerchantFeeModel> TransactionFeesAgregated { get; set; }

    }
}