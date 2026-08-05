
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Merchant
{
    /// <summary>
    /// Represents the AddBankAccountResponse model.
    /// </summary>
    public class AddBankAccountResponse : ClientBaseResponse
    {
        
    /// <summary>
    /// The identifier of the newly created (and immediately authorized) merchant. Empty Guid when the call failed.
    /// </summary>
    /// <value></value>
    public Guid NewMerchantId { get; set; }

    }
}