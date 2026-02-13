
using System;
using Tib.Api.Common;

namespace Tib.Api.Model.Admin
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
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