
using System;
using System.Collections.Generic;
using Tib.Api.Model.Service;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetWalletOperationsResponse model.
    /// </summary>
    public class GetWalletOperationsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public List<WalletOperationModel> DailyOperations { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public decimal BalanceBeforeOperations { get; set; }

    /// <summary>
    /// Gets or sets the delay buffer amount used to define the monetary buffer applied to transaction timing delays.
    /// </summary>
    /// <value>The monetary amount representing the buffer applied to delay calculations.</value>
    public decimal DelayBufferAmount { get; set; }

    }
}