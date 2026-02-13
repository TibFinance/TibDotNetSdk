
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class TransactionCommonWithMeta : TransactionCommon
    {
        
    /// <summary>
    /// Gets or sets the transaction identifier.
    /// </summary>
    /// <value>The transaction identifier.</value>
    public Guid TransactionId { get; set; }

    /// <summary>
    /// Gets or sets the transaction amount.
    /// </summary>
    /// <value>The transaction amount.</value>
    public decimal TransactionAmount { get; set; }

    }
}