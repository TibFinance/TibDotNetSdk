
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
    /// Optional idempotency key (max 200 characters; a new GUID per logical operation is recommended). Honored ONLY by these operations: CreatePayment, CreateFreeOperation, CreateFreeOperationBatch, CreateDirectInteracTransaction, CreateTransactionFromRaw, CreateSupplierTransfer, AdjustWallet, ForcePaymentProcess, RevertTransfer, RelaunchMerchantFailedTransfer — on any other operation the field is ignored. When supplied, a repeated call with the same key and identical parameters returns the original response without re-executing, so a network retry cannot create a duplicate payment or transfer. Keys are scoped to the authenticated login. Responses — including error responses — are cached against the key: use a NEW key for a genuinely new attempt. Reusing a key with different parameters is rejected. Leave null (the default) for the historical, non-idempotent behavior.
    /// </summary>
    public string IdempotencyKey { get; set; }

    }
}