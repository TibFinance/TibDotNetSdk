
using System;
using Tib.Api.Financial;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the TransactionCommonWithMeta model.
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