
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
    /// Display name for the new sub-client.
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// Specifies the language used for the payment request and related communications
    /// </summary>
    /// <value>Must be a valid LanguageEnum value (e.g., EN, DE, FR). Required; defaults to EN if omitted.</value>
    public LanguageEnum Language { get; set; }

    /// <summary>
    /// The ISO 4217 three‑letter code of the currency in which the transfer was executed.
    /// </summary>
    /// <value>One of the supported CurrencyEnum values (e.g., USD, EUR, GBP), always uppercase; matches the currency of the source and destination accounts and is required for all transfer responses.</value>
    public CurrencyEnum Currency { get; set; }

    }
}