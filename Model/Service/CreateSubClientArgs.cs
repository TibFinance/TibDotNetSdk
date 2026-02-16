
using System;
using static Tib.Api.Model.Enum;
using Tib.Api.Common;

namespace Tib.Api.Model.Service
{
    /// <summary>
    /// Represents the CreateSubClientArgs model.
    /// </summary>
    public class CreateSubClientArgs : ClientCallBaseArgs
    {
        
    /// <summary>
    /// Retrieves or assigns the name of the sub-client.
    /// </summary>
    /// <value>Specifies the name associated with the sub-client.</value>
    public string Name { get; set; }

    /// <summary>
    /// Defines the default language for a customer. If not explicitly specified during customer creation, the language setting of the primary merchant is used as the default.
    /// </summary>
    /// <value>Represents the language preference of a customer.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// Retrieves or assigns the currency type used in transactions.
    /// </summary>
    /// <value>This property represents the currency type, defined by the CurrencyEnum, used for financial operations within the TIB Finance system.</value>
    public CurrencyEnum Currency { get; set; }

    }
}