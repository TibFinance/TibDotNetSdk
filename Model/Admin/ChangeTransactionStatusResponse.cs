
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Represents the ChangeTransactionStatusResponse model.
    /// </summary>
    public class ChangeTransactionStatusResponse : ClientBaseResponse
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