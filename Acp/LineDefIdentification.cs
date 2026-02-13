
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Acp;

namespace Tib.Api.Acp
{
    /// <summary>
    /// Object that represent Bill to be paid by an End User
    /// </summary>
    public class LineDefIdentification : LineBaseWithHeader
    {
        
    /// <summary>
    /// Gets or sets the creation date.
    /// </summary>
    /// <value>The creation date.</value>
    public DateTime CreationDate { get; set; }

    /// <summary>
    /// Gets the bank central.
    /// </summary>
    /// <value>The bank central.</value>
    public string BankCentral { get; set; }

    /// <summary>
    /// Gets or sets the money code identifier.
    /// </summary>
    /// <value>The money code identifier.</value>
    public CurrencyEnum MoneyCodeIdentifier { get; set; }

    }
}