
using System;
using System.Collections.Generic;
using Tib.Api.Model.Admin;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the GetWalletInformationsResponse model.
    /// </summary>
    public class GetWalletInformationsResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// A list of wallet objects returned for the specified service.
    /// </summary>
    /// <value>Each element is a WalletModel containing walletId, balance, currency, status, and related metadata. The list may be empty if no wallets are linked to the service; size is limited only by the service's wallet count.</value>
    public List<WalletModel> Wallets { get; set; }

    }
}