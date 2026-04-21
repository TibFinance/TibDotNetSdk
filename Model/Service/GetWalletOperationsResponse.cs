
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
    /// List of daily wallet operation summaries.
    /// </summary>
    /// <value></value>
    public List<WalletOperationModel> DailyOperations { get; set; }

    /// <summary>
    /// Wallet balance before the listed operations were applied.
    /// </summary>
    /// <value></value>
    public decimal BalanceBeforeOperations { get; set; }

    /// <summary>
    /// The amount of buffer reserved to cover service execution delays.
    /// </summary>
    /// <value>Decimal, non‑negative, expressed in the account's base currency; precision up to 4 decimal places.</value>
    public decimal DelayBufferAmount { get; set; }

    }
}