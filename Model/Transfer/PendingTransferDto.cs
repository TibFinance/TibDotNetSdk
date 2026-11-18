
using System;

namespace Tib.Api.Model.Transfer
{
    /// <summary>
    /// Represents the PendingTransferDto model.
    /// </summary>
    public class PendingTransferDto 
    {
        
    /// <summary>
    /// The unique identifier of the transfer.
    /// </summary>
    public Guid TransferId { get; set; }

    /// <summary>
    /// The transfer amount.
    /// </summary>
    public decimal Amount { get; set; }

    /// <summary>
    /// The kind of transfer, "Collection" or "Deposit"; it does not say which side of the transfer you are on. A payment to a supplier reads "Collection" for the paying merchant and for the supplier.
    /// </summary>
    public string Direction { get; set; }

    /// <summary>
    /// The name of the customer of the transfer; empty when the transfer has no customer. For a payment to a supplier, it is the paying merchant.
    /// </summary>
    public string CustomerName { get; set; }

    /// <summary>
    /// The date and time when the transfer was created, in UTC.
    /// </summary>
    public DateTime CreatedDate { get; set; }

    /// <summary>
    /// The unique identifier of your service the transfer is listed under. For a payment to a supplier, the paying merchant and the supplier each read their own service.
    /// </summary>
    public Guid ServiceId { get; set; }

    /// <summary>
    /// The name of your service the transfer is listed under.
    /// </summary>
    public string ServiceName { get; set; }

    }
}