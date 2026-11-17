
using System;
using Tib.Api.Common;
using Tib.Api.Common.Contract;

namespace Tib.Api.Common
{
    /// <summary>
    /// Represents the BaseAuthenticatedCryptedArgs model.
    /// </summary>
    public class BaseAuthenticatedCryptedArgs : ClientCallBaseArgs, IAuthenticatedSessionArgs
    {
        
    /// <summary>
    /// Identifier for the authenticated user session
    /// </summary>
    /// <value>A non‑empty GUID issued at login; must correspond to an active session and be passed unchanged to authorize the CreatePayment request.</value>
    public Guid? SessionToken { get; set; }

    /// <summary>
    /// Idempotency key (max 200 characters; a new GUID per logical operation is recommended): optional, except for CreateTransferBatch and CreateCustomerV2, which require it and refuse a call without one (CreateTransferBatch with error 2100, CreateCustomerV2 with error 2003). Honored ONLY by these operations: CreatePayment, CreateFreeOperation, CreateFreeOperationBatch, CreateTransferBatch, CreateCustomerV2, CreateDirectInteracTransaction, CreateTransactionFromRaw, CreateSupplierTransfer, AdjustWallet, ForcePaymentProcess, RevertTransfer, RelaunchMerchantFailedTransfer — on any other operation the field is ignored. When supplied, for at least 24 hours, a repeated call with the same key and identical parameters returns the original response without re-executing, so a network retry cannot create a duplicate payment, transfer or customer. Keys are scoped to the authenticated login. Responses — including error responses, a 2016 of CreateCustomerV2 excepted — are cached against the key: use a NEW key for a genuinely new attempt. Reusing a key with different parameters is rejected. On the other operations, leave it null (the default) for the historical, non-idempotent behavior.
    /// </summary>
    public string IdempotencyKey { get; set; }

    }
}