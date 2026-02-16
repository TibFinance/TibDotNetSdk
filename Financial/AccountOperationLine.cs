
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
    /// Retrieves or assigns the monetary amount involved in the transaction.
    /// </summary>
    /// <value>Represents the monetary value to be processed.</value>
    public decimal? Amount { get; set; }

    /// <summary>
    /// Gets or sets the account operation direction.
    /// </summary>
    /// <value>The account operation direction.</value>
    public AccountOperationDirectionEnum AccountOperationDirection { get; set; }

    }
}