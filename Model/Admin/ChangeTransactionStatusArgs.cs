
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the ChangeTransactionStatusArgs model.
    /// </summary>
    public class ChangeTransactionStatusArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <value></value>
    public int TransactionStatus { get; set; }

    }
}