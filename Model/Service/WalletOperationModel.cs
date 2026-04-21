
using System;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the WalletOperationModel model.
    /// </summary>
    public class WalletOperationModel 
    {
        
    /// <summary>
    /// Date and time of the wallet operation.
    /// </summary>
    /// <value></value>
    public DateTime Date { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal Amount { get; set; }

    /// <summary>
    /// Whether this operation was a withdrawal from the wallet.
    /// </summary>
    /// <value></value>
    public bool IsWithdrawn { get; set; }

    /// <summary>
    /// Human‑readable description of the transfer
    /// </summary>
    /// <value>Free‑form UTF‑8 text describing the purpose or details of the transfer; optional, max length 255 characters</value>
    public string Description { get; set; }

    }
}