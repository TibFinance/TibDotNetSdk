
using System;
using static Tib.Api.Model.Enum;

namespace Tib.Api.Financial
{
    /// <summary>
    /// Represents the AccountOperationLine model.
    /// </summary>
    public class AccountOperationLine 
    {
        
    /// <summary>
    /// Gets or sets the operation date.
    /// </summary>
    /// <value>The operation date.</value>
    public DateTime OperationDate { get; set; }

    /// <summary>
    /// Gets or sets the operation description.
    /// </summary>
    /// <value>The operation description.</value>
    public string OperationDescription { get; set; }

    /// <summary>
    /// The monetary value of each recurring transfer.
    /// </summary>
    /// <value>Decimal amount in the account's currency, expressed with up to 2 decimal places; must be greater than zero.</value>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or sets the account operation direction.
    /// </summary>
    /// <value>The account operation direction.</value>
    public AccountOperationDirectionEnum AccountOperationDirection { get; set; }

    }
}