
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Model.Client
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class ConsolidationInternalReportEntity 
    {
        
    /// <summary>
    /// Gets or sets the execution date and time of the transaction.
    /// </summary>
    /// <value>A DateTime value indicating when the transaction was executed, stored in UTC.</value>
    public DateTime? ExecutedDate { get; set; }

    /// <summary>
    /// Represents the unique identifier for a group within the TIB Finance API.
    /// </summary>
    /// <value>The GroupId is used to uniquely identify and manage groups, ensuring precise operations within the API.</value>
    public string GroupId { get; set; }

    /// <summary>
    /// Specifies the category of a financial operation.
    /// </summary>
    /// <value>Indicates the type of operation, such as deposit, collection, fee, or other supported categories defined by the API.</value>
    public OperationKindEnum OperationKind { get; set; }

    /// <summary>
    /// Gets or sets the deposit amount.
    /// </summary>
    /// <value>The deposit amount.</value>
    public decimal? DepositAmount { get; set; }

    /// <summary>
    /// Gets or sets the collection amount.
    /// </summary>
    /// <value>The collection amount.</value>
    public decimal? CollectionAmount { get; set; }

    /// <summary>
    /// Gets or sets the returned deposit amount.
    /// </summary>
    /// <value>The returned deposit amount.</value>
    public decimal? ReturnedDepositAmount { get; set; }

    /// <summary>
    /// Gets or sets the returned collection amount.
    /// </summary>
    /// <value>The returned collection amount.</value>
    public decimal? ReturnedCollectionAmount { get; set; }

    /// <summary>
    /// Gets or sets the transaction count.
    /// </summary>
    /// <value>The transaction count.</value>
    public int TransactionCount { get; set; }

    }
}